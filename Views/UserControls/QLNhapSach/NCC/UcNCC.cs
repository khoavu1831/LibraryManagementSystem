using LMS.Data;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcNCC : UserControl
    {
        public UcNCC(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("NHACUNGCAP_ADD");
            var canEdit = permissions.Contains("NHACUNGCAP_EDIT");
            var canDelete = permissions.Contains("NHACUNGCAP_DELETE");
            var canViewDetails = permissions.Contains("NHACUNGCAP_VIEW");
            btnThem.Visible = canAdd;
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);
                    var data = nccService.GetAllNCC();
                    dgvNCC.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemNCC = new FormThemNCC())
            {
                if (formThemNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NCC để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
            string tenNCC = selectedRow.Cells["TenNCC"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formSuaNCC = new FormSuaNCC(idNCC, tenNCC, diaChi, sdt))
            {
                if (formSuaNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NCC để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
            string tenNCC = selectedRow.Cells["TenNCC"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formChiTietNCC = new FormChiTietNCC(idNCC, tenNCC, diaChi, sdt))
            {
                if (formChiTietNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new NCCRepository(context);
                        var nccService = new NCCService(repo);
                        nccService.DeleteNCC(idNCC);
                    }

                    MessageBox.Show("Xóa nhà cung cấp thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa nhà cung cấp thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);

                    var data = nccService.SearchNCC(keyword);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvNCC.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);
                    var data = nccService.GetAllNCC(); // List<NCC>

                    // Xuất Excel, loại trừ các navigation properties nếu có (tương tự NhanVien)
                    // Giả sử NCC có navigation properties như "PhieuNhap" hoặc tương tự, điều chỉnh nếu cần
                    var stream = ExportExcel.Export(
                        data,
                        "NCC",
                        new string[] { "PhieuNhaps" } // Thêm tên navigation properties cần loại trừ nếu có
                    );
                    stream.Position = 0;
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = "NhaCungCap.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                            {
                                stream.CopyTo(fileStream);
                            }
                            MessageBox.Show("Xuất Excel thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất Excel thất bại.\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
