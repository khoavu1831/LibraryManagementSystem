using LMS.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Repository;  // THÊM: Để dùng TaiKhoanRepository
using LMS.Data;        // THÊM: Để dùng LibraryDbContext
using LMS.Helpers;   // THÊM NẾU CÓ CurrentUserContext từ mã cũ

namespace LMS.Forms
{
    public partial class LoginForm : Form
    {
        // Expose quyền ra ngoài form
        public List<string> UserPermissions { get; private set; }
        private readonly VaiTroRepository _vaiTroRepo = new VaiTroRepository(new LibraryDbContext());

        public LoginForm()
        {
            InitializeComponent();
        }


        private async void buttonDangNhap_Click(object sender, EventArgs e)
        {
            var username = textBoxTenDangNhap.Text?.Trim();
            var password = textBoxMatKhau.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ctx = new LibraryDbContext())
            {
                var repo = new TaiKhoanRepository(ctx);
                var user = repo.Authenticate(username, password);

                if (user != null)
                {
                    int roleId = user.IdVaiTro;
                    var vaiTroRepo = new VaiTroRepository(new LibraryDbContext());

                    // Lưu user và quyền hiện tại vào CurrentUserContext
                    CurrentUserContext.SetUser(user);
                    CurrentUserContext.SetQuyenIds(await vaiTroRepo.GetPermissionIdsByRoleIdAsync(roleId));
                    UserPermissions = (await vaiTroRepo.GetPermissionIdsByRoleIdAsync(roleId))
                      .Select(id => id.ToString())
                      .ToList();


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Sai tài khoản / mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void checkBoxAnHien_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMatKhau.UseSystemPasswordChar = !checkBoxAnHien.Checked;
        }
    }
}