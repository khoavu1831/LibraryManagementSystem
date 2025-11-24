using LMS.Data;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Utils.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcTacGia : UserControl
    {
        public UcTacGia(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("TACGIA_ADD");
            var canEdit = permissions.Contains("TACGIA_EDIT");
            var canDelete = permissions.Contains("TACGIA_DELETE");
            var canViewDetails = permissions.Contains("TACGIA_VIEW");
            btnThem.Enabled = canAdd;
            btnSua.Enabled = canEdit;
            btnXoa.Enabled = canDelete;
            btnChiTiet.Enabled = canViewDetails;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new TacGiaRepository(context);
                    var _tacGiaService = new TacGiaService(repo);
                    var data = _tacGiaService.GetAllTacGia();
                    dgvTacGia.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemTacGia = new FormThemTacGia())
            {
                if (formThemTacGia.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tác giả để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTacGia.SelectedRows[0];
            int idTacGia = Convert.ToInt32(selectedRow.Cells["IdTacGia"].Value);
            string tenTacGia = selectedRow.Cells["TenTacGia"].Value.ToString() ?? "";
            DateTime ngaySinh = (DateTime)selectedRow.Cells["NgaySinh"].Value;
            string noiSinh = selectedRow.Cells["NoiSinh"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formSuaTacGia = new FormSuaTacGia(idTacGia, tenTacGia, ngaySinh, noiSinh, sdt))
            {
                if (formSuaTacGia.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tác giả để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTacGia.SelectedRows[0];
            int idTacGia = Convert.ToInt32(selectedRow.Cells["IdTacGia"].Value);
            string tenTacGia = selectedRow.Cells["TenTacGia"].Value.ToString() ?? "";
            DateTime ngaySinh = (DateTime)selectedRow.Cells["NgaySinh"].Value;
            string noiSinh = selectedRow.Cells["NoiSinh"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formChiTietTacGia = new FormChiTietTacGia(idTacGia, tenTacGia, ngaySinh, noiSinh, sdt))
            {
                if (formChiTietTacGia.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tác giả để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTacGia.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idTacGia = Convert.ToInt32(selectedRow.Cells["IdTacGia"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new TacGiaRepository(context);
                        var tacGiaService = new TacGiaService(repo);
                        tacGiaService.DeleteTacGia(idTacGia);

                        MessageBox.Show("Xóa tác giả thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa tác giả thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var repo = new TacGiaRepository(context);
                    var tacGiaService = new TacGiaService(repo);

                    var data = tacGiaService.SearchTacGia(keyword);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy tác giả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvTacGia.DataSource = data;
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
                    var repo = new TacGiaRepository(context);
                    var tgService = new TacGiaService(repo);

                    var data = tgService.GetAllTacGia(); // List<TacGia>

                    // Xuất Excel
                    var stream = ExportExcel.Export(
                        data,
                        "TacGia",
                        new string[] { "Sachs" }  // PHẢI LÀ Sachs
                    );

                    stream.Position = 0;

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = $"TacGia_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

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
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }
    }
}
