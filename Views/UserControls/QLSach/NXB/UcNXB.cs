using LMS.Data;
using LMS.Repository;
using LMS.Services;
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
    public partial class UcNXB : UserControl
    {
        public UcNXB()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NXBRepository(context);
                    var nxbService = new NXBService(repo);
                    var data = nxbService.GetAllNXB();
                    dgvNXB.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemNXB = new FormThemNXB())
            {
                if (formThemNXB.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NXB để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNXB.SelectedRows[0];
            int idNXB = Convert.ToInt32(selectedRow.Cells["IdNXB"].Value);
            string tenNXB = selectedRow.Cells["TenNXB"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formSuaNXB = new FormSuaNXB(idNXB, tenNXB, diaChi, sdt))
            {
                if (formSuaNXB.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NXB để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNXB.SelectedRows[0];
            int idNXB = Convert.ToInt32(selectedRow.Cells["IdNXB"].Value);
            string tenNXB = selectedRow.Cells["TenNXB"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formChiTietNXB = new FormChiTietNXB(idNXB, tenNXB, diaChi, sdt))
            {
                if (formChiTietNXB.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà xuất bản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNXB.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idNXB = Convert.ToInt32(selectedRow.Cells["IdNXB"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new NXBRepository(context);
                        var nxbService = new NXBService(repo);
                        nxbService.DeleteNXB(idNXB);
                    }

                    MessageBox.Show("Xóa nhà xuất bản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa nhà xuất bản thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var repo = new NXBRepository(context);
                    var nxbService = new NXBService(repo);

                    var data = nxbService.SearchNXB(keyword);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhà xuất bản nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvNXB.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
