using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;//  để nhận LibraryDbContext
using LMS.Helpers; // để nhận CurrentUserContext

namespace LMS.Views.UserControls.QuanLy
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            Load += FormDoiMatKhau_Load;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            // Bảo đảm các textbox mật khẩu được ẩn ký tự
            txtMatKhauCu.UseSystemPasswordChar = true;
            textmkm.UseSystemPasswordChar = true;
            textnhaplaimk.UseSystemPasswordChar = true;

            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var matKhauCu = txtMatKhauCu.Text.Trim();
            var matKhauMoi = textmkm.Text.Trim();
            var matKhauNhapLai = textnhaplaimk.Text.Trim();

            // Validate dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(matKhauCu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textmkm.Focus();
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textmkm.Focus();
                return;
            }

            if (matKhauMoi == matKhauCu)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textmkm.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauNhapLai))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textnhaplaimk.Focus();
                return;
            }

            if (!matKhauMoi.Equals(matKhauNhapLai, StringComparison.Ordinal))
            {
                MessageBox.Show("Mật khẩu mới nhập lại không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textnhaplaimk.Focus();
                return;
            }

            try
            {
                using (var db = new LibraryDbContext())
                {
                    var taiKhoan = db.TaiKhoans.FirstOrDefault(x => x.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản để đổi mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!string.Equals(taiKhoan.MatKhau ?? string.Empty, matKhauCu, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauCu.Focus();
                        return;
                    }

                    taiKhoan.MatKhau = matKhauMoi;
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi đổi mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TogglePasswordVisibility(TextBox textBox, CheckBox checkBox)
        {
            textBox.UseSystemPasswordChar = !checkBox.Checked;
        }

        private void chkShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtMatKhauCu, (CheckBox)sender);
        }

        private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textmkm, (CheckBox)sender);
        }

        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textnhaplaimk, (CheckBox)sender);
        }
    }
}
