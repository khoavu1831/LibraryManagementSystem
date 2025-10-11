using LibraryManagementSystem.Data;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class UcNhanVien : UserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new LibraryDbContext())
            {
                var repo = new NhanVienRepository(context);
                var nhanVienService = new NhanVienService(repo);
                var nhanVienList = nhanVienService.getAllNhanVien();
                var nhanVienDataView = nhanVienList.Select(nv => new
                {
                    IdNhanVien = nv.IdNhanVien,
                    TenNhanVien = nv.TenNhanVien,
                    NgaySinh = nv.NgaySinh.ToString("dd/MM/yyyy"),
                    DiaChi = nv.DiaChi,
                    SDT = nv.SDT,
                    Email = nv.Email
                }).ToList();
                dgvNhanVien.DataSource = nhanVienDataView;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            if (formThemNhanVien.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNhanVien.SelectedRows[0];
            string idNhanVien = selectedRow.Cells["IdNhanVien"].Value.ToString();
            string tenNhanVien = selectedRow.Cells["TenNhanVien"].Value.ToString()!;
            string ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString()!;
            string sdt = selectedRow.Cells["SDT"].Value.ToString()!;
            string email = selectedRow.Cells["Email"].Value.ToString()!;

            using (var formSuaNhanVien = new FormSuaNhanVien(idNhanVien, tenNhanVien, ngaySinh, diaChi, sdt, email))
            {

                if (formSuaNhanVien.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            var context = new LibraryDbContext();
            var repo = new NhanVienRepository(context);
            var nhanVienService = new NhanVienService(repo);
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNhanVien.SelectedRows[0];
            string idNhanVien = selectedRow.Cells["IdNhanVien"].Value.ToString();
            string tenNhanVien = selectedRow.Cells["TenNhanVien"].Value.ToString()!;
            string ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString()!;
            string sdt = selectedRow.Cells["SDT"].Value.ToString()!;
            string email = selectedRow.Cells["Email"].Value.ToString()!;

            using (var formChiTietNhanVien = new FormChiTietNhanVien(idNhanVien, tenNhanVien, ngaySinh, diaChi, sdt, email))
            {

                if (formChiTietNhanVien.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNhanVien.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idNhanVien = Convert.ToInt32(selectedRow.Cells["IdNhanVien"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new NhanVienRepository(context);
                        var nhanVienService = new NhanVienService(repo);
                        nhanVienService.DeleteNhanVien(idNhanVien);
                    }

                    MessageBox.Show("Xóa nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa nhân viên thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
