using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using LMS.Views.UserControls.QLSach;
using LMS.Views.Views.UserControls.QLMuonTraSach.MuonTraSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLMuonTraSach
{
    public partial class UcMuonTraSach : UserControl
    {
        private bool _isColumnConfigured = false;
        private int _pageSize = 15;
        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string? _currentTrangThai = null; // Lưu filter hiện tại
        private string? _currentKeyword = null; // Lưu keyword tìm kiếm hiện tại

        public UcMuonTraSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("MUONTRA_ADD");
            var canDelete = permissions.Contains("MUONTRA_CANCEL");
            var canViewDetails = permissions.Contains("MUONTRA_VIEW");
            var canExport = permissions.Contains("MUONTRA_EXPORT");
            btnThem.Visible = canAdd;
            btnHuy.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;
            btnListHuy.Visible = canExport;

            dgvPhieuMuonTra.EnableHeadersVisualStyles = false;
            dgvPhieuMuonTra.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvPhieuMuonTra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhieuMuonTra.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            LoadData();
        }
        private void LoadData(string? trangThai = null)
        {
            _currentTrangThai = trangThai; // Lưu filter
            _currentKeyword = null; // Reset keyword khi đổi filter
            LoadPage(1); // Load trang đầu tiên
        }

        private void LoadPage(int page)
        {
            _currentPage = page;

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    // Convert string sang enum
                    PhieuMuon.TrangThaiEnum? trangThaiEnum = _currentTrangThai switch
                    {
                        "Đang mượn" => PhieuMuon.TrangThaiEnum.DangMuon,
                        "Đã trả" => PhieuMuon.TrangThaiEnum.DaTra,
                        "Đã huỷ" => PhieuMuon.TrangThaiEnum.DaHuy,
                        _ => null
                    };

                    // Lấy total records có filter
                    _totalRecords = pmService.GetTotalRecordsByFilter(trangThaiEnum, _currentKeyword);

                    if (_totalRecords == 0)
                    {
                        _totalPages = 1;
                        _currentPage = 1;
                    }
                    else
                    {
                        _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);

                        // Đảm bảo currentPage không vượt quá totalPages
                        if (_currentPage > _totalPages)
                            _currentPage = _totalPages;
                    }

                    // Lấy data có filter + paging (có thể rỗng)
                    var pmList = _totalRecords == 0
                        ? new List<PhieuMuon>()
                        : pmService.GetByPageWithFilter(_currentPage, _pageSize, trangThaiEnum, _currentKeyword);

                    // Project thành anonymous type TRONG UC (không dùng DTO)
                    var pmDataView = pmList.Select(pm => new
                    {
                        IdPhieuMuon = pm.IdPhieuMuon,
                        TenNhanVien = pm.NhanVien != null ? pm.NhanVien.TenNhanVien : "Chưa có",
                        TenThanhVien = pm.TheThanhVien != null && pm.TheThanhVien.DocGia != null
                            ? pm.TheThanhVien.DocGia.TenDocGia
                            : "Chưa có",
                        NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                        NgayHenTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                        TrangThai = pm.TrangThai.GetDisplayName()
                    }).ToList();

                    // Chỉ config columns lần đầu tiên
                    if (!_isColumnConfigured)
                    {
                        dgvPhieuMuonTra.AutoGenerateColumns = false;
                        dgvPhieuMuonTra.Columns.Clear();
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "IdPhieuMuon",
                            DataPropertyName = "IdPhieuMuon",
                            HeaderText = "Mã phiếu mượn"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TenNhanVien",
                            DataPropertyName = "TenNhanVien",
                            HeaderText = "Nhân viên"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TenThanhVien",
                            DataPropertyName = "TenThanhVien",
                            HeaderText = "Độc giả"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "NgayMuon",
                            DataPropertyName = "NgayMuon",
                            HeaderText = "Ngày mượn"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "NgayHenTra",
                            DataPropertyName = "NgayHenTra",
                            HeaderText = "Ngày hẹn trả"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TrangThai",
                            DataPropertyName = "TrangThai",
                            HeaderText = "Trạng thái"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewButtonColumn
                        {
                            Name = "Tra",
                            HeaderText = "Trả sách",
                            Text = "Trả",
                            UseColumnTextForButtonValue = false
                        });

                        // Cấu hình event 1 lần
                        dgvPhieuMuonTra.CellClick += dgvPhieuMuonTra_CellClick!;
                        dgvPhieuMuonTra.CellFormatting += dgvPhieuMuonTra_CellFormatting!;

                        _isColumnConfigured = true;
                    }

                    dgvPhieuMuonTra.DataSource = pmDataView;

                    // Cập nhật label trang
                    labelTrang.Text = _totalRecords == 0
                        ? "Trang 0/0"
                        : $"Trang {_currentPage}/{_totalPages}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu mượn\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPhieuMuonTra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "Tra" && e.RowIndex >= 0)
            {
                string trangThai = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString() ?? "";

                if (trangThai.Equals("Đang mượn", StringComparison.OrdinalIgnoreCase))
                {
                    dgvPhieuMuonTra.Rows[e.RowIndex].Cells["Tra"].Value = "Trả";
                }
                else
                {
                    dgvPhieuMuonTra.Rows[e.RowIndex].Cells["Tra"].Value = "Hoàn tất";
                }
            }
        }

        private void dgvPhieuMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                if (dgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "Tra")
                {
                    var trangThai = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString();

                    // Nếu đã hoàn tất → không cho click
                    if (!string.Equals(trangThai, "Đang mượn", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Phiếu mượn này đã hoàn tất thủ tục trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Nếu đang mượn → mở form trả
                    var idValue = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["IdPhieuMuon"].Value;
                    if (idValue == null) return;

                    int idPhieuMuon = Convert.ToInt32(idValue);
                    using (var formTraSach = new FormTraSach(idPhieuMuon))
                    {
                        if (formTraSach.ShowDialog(this) == DialogResult.OK)
                        {
                            LoadPage(_currentPage); // Reload trang hiện tại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuMuonTra = new FormThemPhieuMuonTra())
            {
                if (formThemPhieuMuonTra.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPage(_currentPage); // Reload trang hiện tại
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn dòng chưa
                if (dgvPhieuMuonTra.CurrentRow == null || dgvPhieuMuonTra.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn cần xem chi tiết!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID phiếu mượn
                var idValue = dgvPhieuMuonTra.CurrentRow.Cells["IdPhieuMuon"].Value;
                if (idValue == null) return;

                int idPhieuMuon = Convert.ToInt32(idValue);

                // Mở form chi tiết
                using (var formChiTiet = new FormChiTietPhieuMuon(idPhieuMuon))
                {
                    formChiTiet.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở chi tiết: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _currentKeyword = null; // Clear keyword
            txtBoxTimKiem.Clear(); // Clear textbox
            LoadData();
        }

        /// <summary>
        /// Nút DS Hủy - Hiển thị danh sách các phiếu đã hủy
        /// </summary>
        private void btnListHuy_Click(object sender, EventArgs e)
        {
            LoadData("Đã huỷ");
        }

        /// <summary>
        /// Nút Tìm kiếm - Tìm theo tên độc giả hoặc tên nhân viên
        /// </summary>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus();
                return;
            }

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    // Convert string sang enum
                    PhieuMuon.TrangThaiEnum? trangThaiEnum = _currentTrangThai switch
                    {
                        "Đang mượn" => PhieuMuon.TrangThaiEnum.DangMuon,
                        "Đã trả" => PhieuMuon.TrangThaiEnum.DaTra,
                        "Đã huỷ" => PhieuMuon.TrangThaiEnum.DaHuy,
                        _ => null
                    };

                    // Kiểm tra số lượng kết quả TRƯỚC KHI load trang
                    int totalResults = pmService.GetTotalRecordsByFilter(trangThaiEnum, keyword);

                    if (totalResults == 0)
                    {
                        // Không có kết quả - chỉ hiển thị thông báo, không thay đổi dữ liệu hiện tại
                        MessageBox.Show("Không tìm thấy phiếu mượn nào với từ khóa này.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Có kết quả - lưu keyword và load trang
                    _currentKeyword = keyword;
                    LoadPage(1); // Load trang đầu tiên với keyword
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra, chỉ hiển thị thông báo lỗi, không thay đổi dữ liệu
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nút Hủy - Hủy phiếu mượn được chọn
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn dòng chưa
                if (dgvPhieuMuonTra.CurrentRow == null || dgvPhieuMuonTra.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn cần hủy!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin phiếu
                var idValue = dgvPhieuMuonTra.CurrentRow.Cells["IdPhieuMuon"].Value;
                if (idValue == null) return;

                int idPhieuMuon = Convert.ToInt32(idValue);
                string trangThai = dgvPhieuMuonTra.CurrentRow.Cells["TrangThai"].Value?.ToString() ?? "";

                // Chỉ cho hủy phiếu đang mượn
                if (trangThai.Equals("Đã trả", StringComparison.OrdinalIgnoreCase) ||
                    trangThai.Equals("Đã hủy", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Không thể hủy phiếu đã trả hoặc đã hủy!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xác nhận
                var confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn hủy phiếu mượn #{idPhieuMuon}?\n" +
                    "Sách sẽ được trả về kho và phiếu sẽ chuyển sang trạng thái 'Đã hủy'.",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                // Thực hiện hủy
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var ctpmRepo = new ChiTietPhieuMuonRepository(context);
                    var bssRepo = new BanSaoSachRepository(context);
                    var pmService = new PhieuMuonService(pmRepo, ctpmRepo, bssRepo);

                    pmService.HuyPhieuMuon(idPhieuMuon);

                    MessageBox.Show("Hủy phiếu mượn thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPage(_currentPage); // Reload trang hiện tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    // Lấy tất cả phiếu mượn với Include đầy đủ
                    var data = pmService.GetAllPhieuMuonWithIncludes()
                        .Select(pm => new
                        {
                            MaPhieuMuon = pm.IdPhieuMuon,
                            NhanVien = pm.NhanVien?.TenNhanVien ?? "N/A",
                            DocGia = pm.TheThanhVien?.DocGia?.TenDocGia ?? "N/A",
                            NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                            NgayHenTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                            TrangThai = pm.TrangThai.GetDisplayName()
                        })
                        .OrderBy(x => x.MaPhieuMuon)
                        .ToList();

                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var stream = LMS.Utils.Helpers.ExportExcel.Export(data, "phieu_muon", Array.Empty<string>());
                    stream.Position = 0;

                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = $"PhieuMuon_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
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

        /// <summary>
        /// Nút Trang trước
        /// </summary>
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                LoadPage(_currentPage - 1);
        }

        /// <summary>
        /// Nút Trang sau
        /// </summary>
        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
                LoadPage(_currentPage + 1);
        }

        /// <summary>
        /// Label trang (optional, không cần xử lý gì)
        /// </summary>
        private void labelTrang_Click(object sender, EventArgs e)
        {
            // Optional: có thể implement jump to page
        }
    }
}
