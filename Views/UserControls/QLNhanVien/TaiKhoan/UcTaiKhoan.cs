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

namespace LMS.Views.UserControls.QLNhanVien.TaiKhoan
{
    public partial class UcTaiKhoan : UserControl
    {
        public UcTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new LibraryDbContext())
            {
                var repo = new TaiKhoanRepository(context);
                var taiKhoanService = new TaiKhoanService(repo);
                var taiKhoanList = taiKhoanService.getAllTaiKhoan();
                var taiKhoanDataView = taiKhoanList.Select(tk => new
                {
                    IdTaiKhoan = tk.IdTaiKhoan,
                    TenDangNhap = tk.TenTaiKhoan,
                    MatKhau = tk.MatKhau,

                }).ToList();
                dgvTaiKhoan.DataSource = taiKhoanDataView;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản để sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedRow = dgvTaiKhoan.SelectedRows[0];
            string idTaiKhoan = selectedRow.Cells["IdTaiKhoan"].Value.ToString();
            string tenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString()!;
            string matKhau = selectedRow.Cells["MatKhau"].Value.ToString()!;
            using (var formSuaTaiKhoan = new FormSuaTaiKhoan(idTaiKhoan, tenDangNhap, matKhau))
            {
                if (formSuaTaiKhoan.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //var context = new LibraryDbContext();
            //var repo = new TaiKhoanRepository(context);
            //var taiKhoanService = new TaiKhoanService(repo);
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedRow = dgvTaiKhoan.SelectedRows[0];
            string idTaiKhoan = selectedRow.Cells["IdTaiKhoan"].Value.ToString();
            string tenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString()!;
            string matKhau = selectedRow.Cells["MatKhau"].Value.ToString()!;
            using (var formChiTietTaiKhoan = new FormChiTietTaiKhoan(idTaiKhoan, tenDangNhap, matKhau))
            {
                if (formChiTietTaiKhoan.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var selectedRow = dgvTaiKhoan.SelectedRows[0];
            string idTaiKhoan = selectedRow.Cells["IdTaiKhoan"].Value.ToString();
            using (var context = new LibraryDbContext())
            {
                var repo = new TaiKhoanRepository(context);
                var taiKhoanService = new TaiKhoanService(repo);
                var taiKhoanList = taiKhoanService.DeleteTaiKhoan(int.Parse(idTaiKhoan));
            }
            MessageBox.Show("Xóa tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}
