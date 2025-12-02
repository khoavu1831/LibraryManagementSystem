using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcSach : UserControl
    {
        public UcSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("SACH_ADD");
            var canEdit = permissions.Contains("SACH_EDIT");
            var canDelete = permissions.Contains("SACH_DELETE");
            var canViewDetails = permissions.Contains("SACH_VIEW");
            btnThem.Visible = canAdd;
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;

            dgvSach.EnableHeadersVisualStyles = false; // Cho phép đổi màu
            dgvSach.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new SachRepository(context);
                    var sachService = new SachService(repo);
                    var data = sachService.GetAllSach();

                    var dataView = data.Select(s => new
                    {
                        IdSach = s.IdSachFormat,
                        TenSach = s.TenSach,
                        NXB = s.NXB != null ? s.NXB.TenNXB : "Chua co",
                        TheLoai = s.TheLoais != null ? string.Join(", ", s.TheLoais.Select(tl => tl.TenTheloai)) : "Chua co",
                        TacGia = s.TacGias != null ? string.Join(", ", s.TacGias.Select(tg => tg.TenTacGia)) : "Chua co",
                        NamXuatBan = s.NamXuatBan,
                        SoLuongBanSao = s.SoLuongBanSao
                    }).ToList();
                    
                    dgvSach.DataSource = dataView;

                    dgvSach.Columns["IdSach"].HeaderText = "Mã sách";
                    dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                    dgvSach.Columns["NXB"].HeaderText = "Nhà xuất bản";
                    dgvSach.Columns["TheLoai"].HeaderText = "Thể loại";
                    dgvSach.Columns["TacGia"].HeaderText = "Tác giả";
                    dgvSach.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
                    dgvSach.Columns["SoLuongBanSao"].HeaderText = "Số lượng bản sao";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemSach = new FormThemSach())
            {
                if (formThemSach.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 sách để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvSach.SelectedRows[0];
            var idSachFormat = selectedRow.Cells["IdSach"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(idSachFormat))
            {
                MessageBox.Show("Không xác định được sách cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idSach = Convert.ToInt32(idSachFormat.Substring(1));

            using (var context = new LibraryDbContext())
            {
                var sachRepo = new SachRepository(context);
                var sachService = new SachService(sachRepo);

                var sach = sachService.GetSachById(idSach);
                if (sach == null)
                {
                    MessageBox.Show("Không tìm thấy sách trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Điều kiện cho phép sửa:
                // 1) Chưa có bản sao nào
                // 2) Hoặc có bản sao nhưng tất cả đều đang ở tình trạng Tốt (không bản sao nào đang cho mượn)
                var bssRepo = new BanSaoSachRepository(context);
                var banSaoList = bssRepo.GetAll().Where(bss => bss.IdSach == idSach).ToList();

                if (banSaoList.Count > 0 &&
                    banSaoList.Any(bss => bss.TinhTrangSach != BanSaoSach.TinhTrangSachEnum.Tot))
                {
                    MessageBox.Show(
                        "Không thể sửa sách này vì đã có bản sao đang được mượn hoặc không ở tình trạng tốt.",
                        "Không cho phép sửa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (var formSuaSach = new FormSuaSach(idSach))
                {
                    if (formSuaSach.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            var context = new LibraryDbContext();
            var repo = new SachRepository(context);
            var sachService = new SachService(repo);

            if (dgvSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 sách để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvSach.SelectedRows[0];

            string idSachFormat = selectedRow.Cells["IdSach"].Value.ToString()!;
            int idSach = Convert.ToInt32(idSachFormat.Substring(1));
            string tenSach = selectedRow.Cells["TenSach"].Value.ToString() ?? "";
            string theLoai = selectedRow.Cells["TheLoai"].Value.ToString() ?? "";
            string tacGia = selectedRow.Cells["TacGia"].Value.ToString() ?? "";
            string nxb = selectedRow.Cells["NXB"].Value.ToString() ?? "";
            int namXuatBan = Convert.ToInt32(selectedRow.Cells["NamXuatBan"].Value);
            int soLuongBanSao = Convert.ToInt32(selectedRow.Cells["SoLuongBanSao"].Value);
            string moTa = sachService.GetSachById(idSach)!.MoTa!;
            int soTrang = Convert.ToInt32(sachService.GetSachById(idSach)!.SoTrang);
            decimal giaTien = Convert.ToDecimal(sachService.GetSachById(idSach)!.GiaTien);

            using (var formChiTietSach = new FormChiTietSach(idSachFormat, tenSach, theLoai, tacGia, nxb, namXuatBan, moTa, soTrang, soLuongBanSao, giaTien))
            {
                if (formChiTietSach.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvSach.SelectedRows[0];
            var idSachFormat = selectedRow.Cells["IdSach"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(idSachFormat))
            {
                MessageBox.Show("Không xác định được sách cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idSach = Convert.ToInt32(idSachFormat.Substring(1));
            int soLuongBanSao = Convert.ToInt32(selectedRow.Cells["SoLuongBanSao"].Value);

            // Chỉ cho phép xóa khi không có bản sao nào
            if (soLuongBanSao > 0)
            {
                MessageBox.Show("Không thể xóa sách vì đã có bản sao. Vui lòng xóa hết bản sao sách trước.", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new SachRepository(context);
                    var deleted = repo.DeleteById(idSach);
                    if (deleted == null)
                    {
                        MessageBox.Show("Không tìm thấy sách để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Xóa sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa sách thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new SachRepository(context);
                    var sachService = new SachService(repo);

                    var data = sachService.GetListExport();
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var stream = ExportExcel.Export(data, "sach", Array.Empty<string>());
                    stream.Position = 0;

                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = $"Sach_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                            {
                                stream.CopyTo(fileStream);
                            }
                            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất Excel thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Workbook|*.xlsx";
                ofd.Title = "Chọn file Excel chứa danh sách sách";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    var filePath = ofd.FileName;
                    var data = ImportExcel.ReadSachFromFile(filePath);

                    if (data.Count == 0)
                    {
                        MessageBox.Show("File không có dữ liệu hoặc không đọc được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (var context = new LibraryDbContext())
                    {
                        var repo = new SachRepository(context);
                        var sachService = new SachService(repo);

                        var errors = sachService.ImportFromExcel(data);
                        var successCount = data.Count - errors.Count;

                        var message = $"Import hoàn tất.\nThành công: {successCount}\nLỗi: {errors.Count}";
                        if (errors.Count > 0)
                        {
                            message += "\n\nChi tiết lỗi:\n" + string.Join("\n", errors);
                        }

                        MessageBox.Show(message, "Kết quả import", MessageBoxButtons.OK, errors.Count > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nhập Excel thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
