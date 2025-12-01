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

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcTheLoai : UserControl
    {
        public UcTheLoai(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("THELOAI_ADD");
            var canEdit = permissions.Contains("THELOAI_EDIT");
            var canDelete = permissions.Contains("THELOAI_DELETE");

            btnThem.Enabled = canAdd;
            btnSua.Enabled = canEdit;
            btnXoa.Enabled = canDelete;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new TheLoaiRepository(context);
                    var theLoaiService = new TheLoaiService(repo);
                    var data = theLoaiService.GetAllTheLoai();
                    dgvTheLoai.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemTheLoai = new FormThemTheLoai())
            {
                if (formThemTheLoai.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 thể loại để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTheLoai.SelectedRows[0];
            int idTheLoai = Convert.ToInt32(selectedRow.Cells["IdTheLoai"].Value);
            string tenTheLoai = selectedRow.Cells["TenTheLoai"].Value.ToString() ?? "";

            using (var formSuaTheLoai = new FormSuaTheLoai(idTheLoai, tenTheLoai))
            {
                if (formSuaTheLoai.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 thể loại để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTheLoai.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idTheLoai = Convert.ToInt32(selectedRow.Cells["IdTheLoai"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new TheLoaiRepository(context);
                        var theLoaiService = new TheLoaiService(repo);
                        theLoaiService.DeleteTheLoai(idTheLoai);
                    }

                    MessageBox.Show("Xóa thể loại thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa thể loại thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim().ToLower();
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new TheLoaiRepository(context);
                    var theLoaiService = new TheLoaiService(repo);

                    var data = theLoaiService.Search(keyword);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thể loại nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvTheLoai.DataSource = data;
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
                    var repo = new TheLoaiRepository(context);
                    var theLoaiService = new TheLoaiService(repo);
                    var data = theLoaiService.GetAllTheLoai(); // List<TheLoai>

                    // Xuất Excel, loại trừ các navigation properties nếu có (ví dụ: "Sachs" nếu liên kết với sách)
                    var stream = ExportExcel.Export(
                        data,
                        "TheLoai",
                        new string[] { "Sachs" } // Thêm tên navigation properties cần loại trừ nếu có
                    );
                    stream.Position = 0;
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = "TheLoai.xlsx";
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