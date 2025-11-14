using LMS.Repository;
using LMS.Services;
using LMS.Views.UserControls.QLPhat;
using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using LMS.Helpers;
using System.IO;


namespace LMS.Views.UserControls.QLPhat
{
    public partial class UcPhat : UserControl
    {
        //private readonly PhatService _phatService;
        private List<dynamic> _allPhieuPhatData = new List<dynamic>();

        // Thêm vào sau dòng: private List<dynamic> _allPhieuPhatData = new List<dynamic>();
        private int _pageSize = 10;
        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string? _currentTrangThai = null; // Lưu filter hiện tại

        public UcPhat(List<string> permissions)
        {
            InitializeComponent();
            var canCollected = permissions.Contains("PHAT_COLLECTED_LIST");
            var canDelete = permissions.Contains("PHAT_CANCEL");
            var canViewDetails = permissions.Contains("PHAT_VIEW");
            var canExportExcel = permissions.Contains("PHAT_EXPORT");

            btnDSThu.Enabled = canCollected;
            btnHuy.Enabled = canDelete;
            btnChiTiet.Enabled = canViewDetails;
            btnExcel.Enabled = canExportExcel;
            LoadData();
            // Event handlers cho các nút lọc
            btnDSThu.Click += btnDSThu_Click;
            btnDSHuy.Click += btnDSHuy_Click;

            // Event handler cho tìm kiếm
            btnTimKiem.Click += btnTimKiem_Click;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string? trangThai = null)
        {
            _currentTrangThai = trangThai; // Lưu filter
            LoadPage(1); // Load trang đầu tiên
        }

        private void LoadPage(int page)
        {
            _currentPage = page;

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var query = context.PhieuPhats
                        .Include(pp => pp.ChiTietPhieuPhats!)
                            .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                                .ThenInclude(ctpm => ctpm.PhieuMuon!)
                                    .ThenInclude(pm => pm.TheThanhVien!)
                                        .ThenInclude(ttv => ttv.DocGia)
                        .AsNoTracking()
                        .AsQueryable();

                    // Áp dụng filter nếu có
                    if (_currentTrangThai == "Đã thu")
                        query = query.Where(pp => pp.TrangThai == PhieuPhat.TrangThaiEnum.DaThu);
                    else if (_currentTrangThai == "Đã huỷ")
                        query = query.Where(pp => pp.TrangThai == PhieuPhat.TrangThaiEnum.DaHuy);

                    // Đếm tổng số records
                    _totalRecords = query.Count();
                    _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);

                    // Nếu không có dữ liệu
                    if (_totalPages == 0)
                    {
                        _totalPages = 1;
                        dgvPhat.DataSource = new List<object>();
                        labelTrang.Text = "Trang 0/0";
                        return;
                    }

                    // Đảm bảo currentPage không vượt quá totalPages
                    if (_currentPage > _totalPages)
                        _currentPage = _totalPages;

                    // Lấy dữ liệu theo trang
                    var dataView = query
                        .OrderByDescending(pp => pp.NgayLap)
                        .Skip((_currentPage - 1) * _pageSize)
                        .Take(_pageSize)
                        .ToList()
                        .Select(pp => new
                        {
                            IdPhieuPhat = pp.IdPhieuPhat,
                            NgayLap = pp.NgayLap,
                            DocGia = pp.ChiTietPhieuPhats?
                                        .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
                                        .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ",
                            TongTienPhat = pp.ChiTietPhieuPhats?.Sum(x => x.TienPhatTra) ?? 0m,
                            TrangThai = pp.TrangThai.GetDisplayName()
                        })
                        .ToList();

                    dgvPhat.Columns.Clear();
                    dgvPhat.AutoGenerateColumns = true;
                    dgvPhat.DataSource = dataView;

                    dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
                    dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
                    dgvPhat.Columns["TongTienPhat"].HeaderText = "Tổng tiền phạt";
                    dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

                    dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvPhat.EnableHeadersVisualStyles = false;
                    dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                    dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Thêm nút Thanh toán
                    if (dgvPhat.Columns["ThanhToan"] == null)
                    {
                        var btnCol = new DataGridViewButtonColumn
                        {
                            Name = "ThanhToan",
                            HeaderText = "Thanh toán",
                            Text = "Thanh toán",
                            UseColumnTextForButtonValue = true,
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        };
                        dgvPhat.Columns.Add(btnCol);
                    }

                    // Cập nhật label trang
                    labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";

                    // Đăng ký sự kiện để disable nút theo trạng thái
                    dgvPhat.DataBindingComplete -= dgvPhat_DataBindingComplete;
                    dgvPhat.DataBindingComplete += dgvPhat_DataBindingComplete;
                    DisablePayButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu phạt\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // private void LoadData(string? trangThai = null)
        // {
        //     try
        //     {
        //         using (var context = new LibraryDbContext())
        //         {
        //             var query = context.PhieuPhats
        //                 .Include(pp => pp.ChiTietPhieuPhats!)
        //                     .ThenInclude(ct => ct.ChiTietPhieuMuon!)
        //                         .ThenInclude(ctpm => ctpm.PhieuMuon!)
        //                             .ThenInclude(pm => pm.TheThanhVien!)
        //                                 .ThenInclude(ttv => ttv.DocGia)
        //                 .AsNoTracking()
        //                 .AsQueryable();

        //             if (trangThai == "Đã thu")
        //                 query = query.Where(pp => pp.TrangThai == PhieuPhat.TrangThaiEnum.DaThu);
        //             else if (trangThai == "Đã huỷ")
        //                 query = query.Where(pp => pp.TrangThai == PhieuPhat.TrangThaiEnum.DaHuy);

        //             var dataView = query
        //                 .ToList()
        //                 .Select(pp => new
        //                 {
        //                     IdPhieuPhat = pp.IdPhieuPhat,
        //                     NgayLap = pp.NgayLap,
        //                     DocGia = pp.ChiTietPhieuPhats?
        //                                 .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
        //                                 .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ",
        //                     TongTienPhat = pp.ChiTietPhieuPhats?.Sum(x => x.TienPhatTra) ?? 0m,
        //                     TrangThai = pp.TrangThai.GetDisplayName()
        //                 })
        //                 .OrderByDescending(x => x.NgayLap)
        //                 .ToList();

        //             dgvPhat.Columns.Clear();
        //             dgvPhat.AutoGenerateColumns = true;
        //             dgvPhat.DataSource = dataView;

        //             dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
        //             dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
        //             dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
        //             dgvPhat.Columns["TongTienPhat"].HeaderText = "Tổng tiền phạt";
        //             dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

        //             dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        //             dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
        //             dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        //             dgvPhat.EnableHeadersVisualStyles = false;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        //             // Thêm nút Thanh toán ở ngoài cùng
        //             if (dgvPhat.Columns["ThanhToan"] == null)
        //             {
        //                 var btnCol = new DataGridViewButtonColumn
        //                 {
        //                     Name = "ThanhToan",
        //                     HeaderText = "Thanh toán",
        //                     Text = "Thanh toán",
        //                     UseColumnTextForButtonValue = true,
        //                     AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        //                 };
        //                 dgvPhat.Columns.Add(btnCol);
        //             }

        //             // Đăng ký sự kiện để disable nút theo trạng thái
        //             dgvPhat.DataBindingComplete -= dgvPhat_DataBindingComplete;
        //             dgvPhat.DataBindingComplete += dgvPhat_DataBindingComplete;
        //             DisablePayButtons();
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show($"Không thể tải dữ liệu phiếu phạt\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }
        // }

        private void dgvPhat_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisablePayButtons();
        }

        private void DisablePayButtons()
        {
            if (dgvPhat.Columns["ThanhToan"] == null) return;
            int payColIndex = dgvPhat.Columns["ThanhToan"].Index;

            foreach (DataGridViewRow row in dgvPhat.Rows)
            {
                var status = row.Cells["TrangThai"].Value?.ToString() ?? "";
                bool canPay = status.Equals("Chưa thu", StringComparison.OrdinalIgnoreCase);

                if (!canPay)
                {
                    // Thay nút bằng text cell để disable
                    var textCell = new DataGridViewTextBoxCell
                    {
                        Value = "" // để trống
                    };

                    row.Cells[payColIndex] = textCell;
                    textCell.ReadOnly = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuPhat = new FormThemPhieuPhat())
            {
                formThemPhieuPhat.ShowDialog(this);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu phạt để hủy.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvPhat.SelectedRows[0];
            var idValue = row.Cells["IdPhieuPhat"].Value;
            var trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";
            if (idValue == null)
            {
                MessageBox.Show("Không xác định được phiếu phạt.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.Equals(trangThai, "Chưa thu", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ có thể hủy phiếu phạt ở trạng thái Chưa thu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPhieuPhat = Convert.ToInt32(idValue);

            var confirm = MessageBox.Show("Bạn chắc chắn muốn hủy phiếu phạt này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuPhatRepository(context);
                    var pp = repo.GetById(idPhieuPhat);
                    if (pp == null)
                    {
                        MessageBox.Show("Không tìm thấy phiếu phạt.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (pp.TrangThai != PhieuPhat.TrangThaiEnum.ChuaThu)
                    {
                        MessageBox.Show("Phiếu phạt không ở trạng thái Chưa thu.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    pp.TrangThai = PhieuPhat.TrangThaiEnum.DaHuy;
                    repo.Update(pp); // lưu trạng thái Hủy
                }

                MessageBox.Show("Đã hủy phiếu phạt.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(_currentTrangThai);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hủy thất bại.\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu phạt để xem chi tiết.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvPhat.SelectedRows[0];
            if (row.Cells["IdPhieuPhat"]?.Value == null)
            {
                MessageBox.Show("Không xác định được phiếu phạt.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPhieuPhat = Convert.ToInt32(row.Cells["IdPhieuPhat"].Value);
            using (var formChiTietPhieuPhat = new FormChiTietPhieuPhat(idPhieuPhat))
            {
                formChiTietPhieuPhat.ShowDialog(this);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var phieuPhats = context.PhieuPhats
                        .Include(pp => pp.ChiTietPhieuPhats!)
                            .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                                .ThenInclude(ctpm => ctpm.PhieuMuon!)
                                    .ThenInclude(pm => pm.TheThanhVien!)
                                        .ThenInclude(ttv => ttv.DocGia)
                        .AsNoTracking()
                        .ToList();

                    var data = phieuPhats.Select(pp => new
                    {
                        IdPhieuPhat = pp.IdPhieuPhat,
                        NgayLap = pp.NgayLap.ToString("dd/MM/yyyy"),
                        DocGia = pp.ChiTietPhieuPhats?
                                     .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
                                     .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ",
                        TongTienPhat = pp.ChiTietPhieuPhats?.Sum(x => x.TienPhatTra) ?? 0m,
                        TrangThai = pp.TrangThai.GetDisplayName()
                    })
                    .OrderByDescending(x => x.IdPhieuPhat)
                    .ToList();

                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var stream = LMS.Utils.Helpers.ExportExcel.Export(data, "phieu_phat", Array.Empty<string>());
                    stream.Position = 0;

                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = $"PhieuPhat_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                            {
                                stream.CopyTo(fileStream);
                            }
                            MessageBox.Show("Xuất Excel thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất Excel thất bại.\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvPhat.Columns[e.ColumnIndex].Name == "ThanhToan")
            {
                var row = dgvPhat.Rows[e.RowIndex];
                var idValue = row.Cells["IdPhieuPhat"].Value;
                var trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";

                if (idValue == null) return;

                // Chặn thanh toán khi không phải "Chưa thu"
                if (!string.Equals(trangThai, "Chưa thu", StringComparison.OrdinalIgnoreCase))
                {
                    return; // Không làm gì cả
                }

                int idPhieuPhat = Convert.ToInt32(idValue);
                var tongTien = row.Cells["TongTienPhat"].Value?.ToString() ?? "0";

                // Xác nhận thanh toán
                var confirm = MessageBox.Show(
                    $"Xác nhận thanh toán phiếu phạt #{idPhieuPhat}?\nTổng tiền: {tongTien}đ",
                    "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new PhieuPhatRepository(context);
                        var pp = repo.GetById(idPhieuPhat);
                        if (pp == null)
                        {
                            MessageBox.Show("Không tìm thấy phiếu phạt.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (pp.TrangThai != PhieuPhat.TrangThaiEnum.ChuaThu)
                        {
                            MessageBox.Show("Phiếu phạt không ở trạng thái Chưa thu.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Cập nhật trạng thái thành "Đã thu"
                        pp.TrangThai = PhieuPhat.TrangThaiEnum.DaThu;
                        repo.Update(pp);
                    }

                    MessageBox.Show("Thanh toán thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu
                    LoadData(_currentTrangThai);

                    // Gọi trực tiếp để disable nút
                    DisablePayButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thanh toán thất bại.\n{ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDSThu_Click(object sender, EventArgs e)
        {
            LoadData("Đã thu");
        }

        private void btnDSHuy_Click(object sender, EventArgs e)
        {
            LoadData("Đã huỷ");
        }

        // Thêm vào UcPhat.cs
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();

            // Kiểm tra nếu không nhập gì
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus(); // Focus vào textbox để người dùng nhập
                return;
            }

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var query = context.PhieuPhats
                        .Include(pp => pp.ChiTietPhieuPhats)
                        .ThenInclude(ctpp => ctpp.ChiTietPhieuMuon)
                        .ThenInclude(ctpm => ctpm.PhieuMuon)
                        .ThenInclude(pm => pm.TheThanhVien)
                        .ThenInclude(ttv => ttv.DocGia)
                        .AsNoTracking()
                        .AsQueryable();

                    // Tìm kiếm theo tên độc giả
                    query = query.Where(pp =>
                        pp.ChiTietPhieuPhats.Any(ctpp =>
                            ctpp.ChiTietPhieuMuon.PhieuMuon.TheThanhVien.DocGia.TenDocGia
                                .Contains(keyword)));

                    var phieuPhats = query.ToList();

                    var data = phieuPhats.Select(pp => new
                    {
                        IdPhieuPhat = pp.IdPhieuPhat,
                        NgayLap = pp.NgayLap,
                        DocGia = pp.ChiTietPhieuPhats.FirstOrDefault()?.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia ?? "",
                        TongTienPhat = pp.ChiTietPhieuPhats.Sum(ctpp => ctpp.TienPhatTra),
                        TrangThai = pp.TrangThai.GetDisplayName()
                    }).ToList();

                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Không cần set DataSource nếu không có kết quả
                    }

                    dgvPhat.DataSource = data;
                    DisablePayButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tìm kiếm thất bại.\n{ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            LoadPage(_currentPage + 1);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            LoadPage(_currentPage - 1);
        }
    }
}
