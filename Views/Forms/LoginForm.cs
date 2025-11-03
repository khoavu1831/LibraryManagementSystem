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
// using LMS.Helpers;   // THÊM NẾU CÓ CurrentUserContext từ mã cũ

namespace LMS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            var username = textBoxTenDangNhap.Text?.Trim();
            var password = textBoxMatKhau.Text ?? string.Empty;

            // Validation cơ bản (tùy chọn, giống service)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra với DB
            using (var ctx = new LibraryDbContext())
            {
                var repo = new TaiKhoanRepository(ctx);
                var user = repo.Authenticate(username, password);  // Gọi phương thức mới

                if (user != null)
                {
                    // Nếu có CurrentUserContext (từ mã cũ), lưu user
                    // CurrentUserContext.SetUser(user);  // Uncomment nếu cần

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            // Sai thông tin
            MessageBox.Show("Sai tài khoản / mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkBoxAnHien_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMatKhau.UseSystemPasswordChar = !checkBoxAnHien.Checked;
        }
    }
}