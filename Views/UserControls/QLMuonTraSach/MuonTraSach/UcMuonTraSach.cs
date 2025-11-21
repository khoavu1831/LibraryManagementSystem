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
        public UcMuonTraSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("MUONTRA_ADD");
            var canDelete = permissions.Contains("MUONTRA_CANCEL");
            var canViewDetails = permissions.Contains("MUONTRA_VIEW");
            var canExport = permissions.Contains("MUONTRA_EXPORT");
            btnThem.Enabled = canAdd;
            btnHuy.Enabled = canDelete;
            btnChiTiet.Enabled = canViewDetails;
            btnListHuy.Enabled = canExport;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    // Lấy tất cả phiếu (kể cả đã hủy)
                    var pmList = pmService.GetAllPhieuMuon()
                        .ToList();

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

                    dgvPhieuMuonTra.DataSource = pmDataView;

                    // ===== Cấu hình các cột =====
                    if (!_isColumnConfigured)
                    {
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


                        // Cấu hình event
                        dgvPhieuMuonTra.CellClick += dgvPhieuMuonTra_CellClick!;
                        dgvPhieuMuonTra.CellFormatting += dgvPhieuMuonTra_CellFormatting!;

                        _isColumnConfigured = true;
                    }
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
                            LoadData();
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
                    LoadData();
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
            LoadData();
        }

        /// <summary>
        /// Nút DS Hủy - Hiển thị danh sách các phiếu đã hủy
        /// </summary>
        private void btnListHuy_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    // Lấy phiếu có TrangThai = DaHuy
                    var pmListHuy = pmService.GetAllPhieuMuon()
                        .Where(pm => pm.TrangThai == PhieuMuon.TrangThaiEnum.DaHuy)
                        .ToList();

                    var pmDataView = pmListHuy.Select(pm => new
                    {
                        IdPhieuMuon = pm.IdPhieuMuon,
                        TenNhanVien = pm.NhanVien?.TenNhanVien ?? "N/A",
                        TenThanhVien = pm.TheThanhVien?.DocGia?.TenDocGia ?? "N/A",
                        NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                        NgayHenTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                        TrangThai = pm.TrangThai.GetDisplayName()
                    }).ToList();

                    dgvPhieuMuonTra.DataSource = pmDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phiếu hủy: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    LoadData(); // Reload
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

                    var data = pmService.GetAllPhieuMuon()
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
    }
}
