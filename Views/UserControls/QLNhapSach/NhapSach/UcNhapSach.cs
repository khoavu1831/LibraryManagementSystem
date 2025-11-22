using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Utils.Helpers;
using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcNhapSach : UserControl
    {
        private bool _isColumnConfigured = false;
        
        public UcNhapSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("NHAPSACH_ADD");
            var canEdit = permissions.Contains("NHAPSACH_EDIT");
            var canDelete = permissions.Contains("NHAPSACH_CANCEL");
            var canViewDetails = permissions.Contains("NHAPSACH_VIEW");
            var canExport = permissions.Contains("NHAPSACH_EXPORT");
            btnThem.Enabled = canAdd;
            btnChiTiet.Enabled = canViewDetails;
            btnXoa.Enabled = canDelete;
            btnLamMoi.Enabled = true;
            btnExcel.Enabled = canExport;
            LoadData();
        }
        
        private void LoadData(string? filter = null)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);
                    var pnList = pnService.GetAllPhieuNhap();

                    // Filter theo trạng thái
                    if (!string.IsNullOrEmpty(filter))
                    {
                        if (filter == "Đã hủy")
                        {
                            pnList = pnList.Where(pn => pn.TrangThai == PhieuNhap.TrangThaiEnum.DaHuy).ToList();
                        }
                    }

                    var pnDataView = pnList.Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC != null ? pn.NCC.TenNCC : "Chưa có",
                        TenNhanVien = pn.NhanVien != null ? pn.NhanVien.TenNhanVien : "Chưa có",
                        NgayNhap = pn.NgayNhap.ToString("dd/MM/yyyy"),
                        SoLuongSach = pn.SoLuongSach,
                        TongTien = pn.TongTienNhap,
                        LoaiPhieuNhap = pn.LoaiPhieuNhap.GetDisplayName(),
                        TrangThai = pn.TrangThai.GetDisplayName()
                    }).ToList();

                    // Cấu hình cột chỉ một lần
                    if (!_isColumnConfigured && pnDataView.Count > 0)
                    {
                        dgvPhieuNhap.AutoGenerateColumns = false;
                        dgvPhieuNhap.Columns.Clear();

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "IdPhieuNhap",
                            DataPropertyName = "IdPhieuNhap",
                            HeaderText = "Mã Phiếu Nhập",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "TenNCC",
                            DataPropertyName = "TenNCC",
                            HeaderText = "Nhà Cung Cấp",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "TenNhanVien",
                            DataPropertyName = "TenNhanVien",
                            HeaderText = "Nhân Viên Nhập",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "NgayNhap",
                            DataPropertyName = "NgayNhap",
                            HeaderText = "Ngày Nhập",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "SoLuongSach",
                            DataPropertyName = "SoLuongSach",
                            HeaderText = "Số Lượng",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "TongTien",
                            DataPropertyName = "TongTien",
                            HeaderText = "Tổng Tiền (VNĐ)",
                            ReadOnly = true,
                            DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "LoaiPhieuNhap",
                            DataPropertyName = "LoaiPhieuNhap",
                            HeaderText = "Loại Phiếu",
                            ReadOnly = true
                        });

                        dgvPhieuNhap.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "TrangThai",
                            DataPropertyName = "TrangThai",
                            HeaderText = "Trạng Thái",
                            ReadOnly = true
                        });

                        _isColumnConfigured = true;
                    }

                    dgvPhieuNhap.DataSource = pnDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuNhap = new FormThemPhieuNhap())
            {
                formThemPhieuNhap.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu nhập cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idPhieuNhap = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["IdPhieuNhap"].Value);
                var trangThai = dgvPhieuNhap.CurrentRow.Cells["TrangThai"].Value?.ToString() ?? "";

                if (trangThai == "Đã hủy")
                {
                    MessageBox.Show("Phiếu nhập này đã được hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn hủy phiếu nhập #{idPhieuNhap}?",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new PhieuNhapRepository(context);
                        var pnService = new PhieuNhapService(repo);
                        pnService.HuyPhieuNhap(idPhieuNhap);
                    }

                    MessageBox.Show("Hủy phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hủy phiếu nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnListHuy_Click(object sender, EventArgs e)
        {
            LoadData("Đã hủy");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus();
                return;
            }

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);
                    var pnList = pnService.TimKiemPhieuNhap(keyword);

                    var pnDataView = pnList.Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC != null ? pn.NCC.TenNCC : "Chưa có",
                        TenNhanVien = pn.NhanVien != null ? pn.NhanVien.TenNhanVien : "Chưa có",
                        SoLuongNhap = pn.SoLuongSach,
                        LoaiPhieuNhap = pn.LoaiPhieuNhap.GetDisplayName()
                    }).ToList();

                    dgvPhieuNhap.DataSource = pnDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);
                    var pnList = pnService.GetAllPhieuNhap();

                    var pnDataView = pnList.Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC?.TenNCC ?? "Chưa có",
                        TenNhanVien = pn.NhanVien?.TenNhanVien ?? "Chưa có",
                        NgayNhap = pn.NgayNhap.ToString("dd/MM/yyyy"),
                        SoLuongSach = pn.SoLuongSach,
                        TongTien = pn.TongTienNhap.ToString("N0") + " VNĐ",
                        LoaiPhieuNhap = pn.LoaiPhieuNhap.GetDisplayName()
                    }).ToList();

                    if (pnDataView.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var stream = ExportExcel.Export(pnDataView, "phieu_nhap", Array.Empty<string>());
                    
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.FileName = $"PhieuNhap_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                            {
                                stream.WriteTo(fileStream);
                            }
                            MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
