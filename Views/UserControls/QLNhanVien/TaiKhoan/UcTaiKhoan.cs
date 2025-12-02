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
        public UcTaiKhoan(List<string> permissions)
        {
            InitializeComponent();
            var canEdit = permissions.Contains("TAIKHOAN_EDIT");
            var canDelete = permissions.Contains("TAIKHOAN_DELETE");
            var canViewDetails = permissions.Contains("TAIKHOAN_VIEW");
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;

            dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

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

                dgvTaiKhoan.Columns["IdTaiKhoan"].HeaderText = "Mã tài khoản";
                dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
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
                    var repo = new TaiKhoanRepository(context);
                    var taiKhoanService = new TaiKhoanService(repo);
                    var taiKhoanList = taiKhoanService.SearchTaiKhoan(keyword);
                    var taiKhoanDataView = taiKhoanList.Select(tk => new
                    {
                        IdTaiKhoan = tk.IdTaiKhoan,
                        TenDangNhap = tk.TenTaiKhoan,
                        MatKhau = tk.MatKhau,

                    }).ToList();

                    if (taiKhoanDataView.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        return;
                    }

                    dgvTaiKhoan.DataSource = taiKhoanDataView;

                    dgvTaiKhoan.Columns["IdTaiKhoan"].HeaderText = "Mã tài khoản";
                    dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                    dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tìm kiếm thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
