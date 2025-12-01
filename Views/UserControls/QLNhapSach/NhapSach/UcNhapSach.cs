using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Utils.Helpers;
using LMS.Views.UserControls.QLNhapSach.NhapSach;
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
        private int _pageSize = 15;
        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string? _currentTrangThai = null; // Lưu filter hiện tại
        private string? _currentKeyword = null; // Lưu keyword tìm kiếm hiện tại

        public UcNhapSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("NHAPSACH_ADD");
            var canEdit = permissions.Contains("NHAPSACH_EDIT");
            var canDelete = permissions.Contains("NHAPSACH_CANCEL");
            var canViewDetails = permissions.Contains("NHAPSACH_VIEW");
            var canExport = permissions.Contains("NHAPSACH_EXPORT");
            btnThem.Visible = canAdd;
            btnChiTiet.Visible = canViewDetails;
            btnXoa.Visible = canDelete;
            btnLamMoi.Visible = true;
            btnExcel.Visible = canExport;
            LoadData();
        }

        private void LoadData(string? filter = null)
        {
            _currentTrangThai = filter; // Lưu filter
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
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);

                    // Convert string sang enum
                    PhieuNhap.TrangThaiEnum? trangThaiEnum = _currentTrangThai switch
                    {
                        "Đã hủy" => PhieuNhap.TrangThaiEnum.DaHuy,
                        _ => null
                    };

                    // Lấy total records có filter
                    _totalRecords = pnService.GetTotalRecordsByFilter(trangThaiEnum, _currentKeyword);
                    _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);

                    // Nếu không có dữ liệu
                    if (_totalPages == 0)
                    {
                        _totalPages = 1;
                        dgvPhieuNhap.DataSource = new List<object>();
                        labelTrang.Text = "Trang 0/0";
                        return;
                    }

                    // Đảm bảo currentPage không vượt quá totalPages
                    if (_currentPage > _totalPages)
                        _currentPage = _totalPages;

                    // Lấy data có filter + paging
                    var pnList = pnService.GetByPageWithFilter(_currentPage, _pageSize, trangThaiEnum, _currentKeyword);

                    // Project thành anonymous type TRONG UC (không dùng DTO)
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

                    // Chỉ config columns lần đầu tiên
                    if (!_isColumnConfigured)
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

                    // Cập nhật label trang
                    labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";
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
                if (formThemPhieuNhap.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPage(_currentPage); // Reload trang hiện tại sau khi thêm
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu nhập cần xem chi tiết!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idPhieuNhap = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["IdPhieuNhap"].Value);

                var formChiTiet = new FormChiTietPhieuNhap(idPhieuNhap);
                formChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở chi tiết phiếu nhập: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    LoadPage(_currentPage); // Reload trang hiện tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hủy phiếu nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _currentKeyword = null; // Clear keyword
            txtBoxTimKiem.Text = string.Empty;
            LoadData(); // Load lại từ đầu
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

            _currentKeyword = keyword; // Lưu keyword
            LoadPage(1); // Load trang đầu tiên với keyword
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);
                    
                    // Lấy tất cả phiếu nhập với Include đầy đủ
                    var pnList = pnService.GetAllPhieuNhapWithIncludes();

                    var pnDataView = pnList.Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC?.TenNCC ?? "Chưa có",
                        TenNhanVien = pn.NhanVien?.TenNhanVien ?? "Chưa có",
                        NgayNhap = pn.NgayNhap.ToString("dd/MM/yyyy"),
                        SoLuongSach = pn.SoLuongSach,
                        TongTien = pn.TongTienNhap.ToString("N0") + " VNĐ",
                        LoaiPhieuNhap = pn.LoaiPhieuNhap.GetDisplayName(),
                        TrangThai = pn.TrangThai.GetDisplayName()
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

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý gì
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
    }
}
