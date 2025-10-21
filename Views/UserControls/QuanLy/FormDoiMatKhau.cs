using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QuanLy
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string taiKhoan = texttk.Text.Trim();
            string mkCu = txtMatKhauCu.Text.Trim();
            string mkMoi = textmkm.Text.Trim();
            string nhapLai = textnhaplaimk.Text.Trim();

            // 🔹 Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(taiKhoan) ||
                string.IsNullOrEmpty(mkCu) ||
                string.IsNullOrEmpty(mkMoi) ||
                string.IsNullOrEmpty(nhapLai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Kiểm tra mật khẩu mới và nhập lại
            if (mkMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔹 Giả lập kiểm tra mật khẩu hiện tại (sau này thay bằng truy vấn DB)
            string mkHienTaiTrongDB = "123456"; // ví dụ tạm
            if (mkCu != mkHienTaiTrongDB)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔹 Cập nhật mật khẩu mới (sau này thêm code truy vấn DB ở đây)
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔹 Đóng form sau khi đổi xong
            this.Close();
        }
    }
}
