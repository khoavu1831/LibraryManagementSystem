using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QuanLy
{
    public partial class FormSuaThongTin : Form
    {
        public FormSuaThongTin()
        {
            InitializeComponent();
        }

        private void FormSuaThongTin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu người dùng nhập
            string ten = txtTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string gioiTinh = txtGioiTinh.Text.Trim();
            string email = txtEmail.Text.Trim();
            string ngaySinh = txtNgaySinh.Text.Trim(); // Giả sử bạn có textbox ngày sinh

            // Kiểm tra nhập thiếu
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt) ||
                string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(ngaySinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại: 10 số và bắt đầu bằng 0
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 số và bắt đầu bằng số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giới tính chỉ được Nam hoặc Nữ (không phân biệt hoa thường)
            if (!(gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase) || gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Giới tính chỉ được nhập 'Nam' hoặc 'Nữ'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email có đuôi .com
            if (!email.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email phải có đuôi .com!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng ngày sinh (DD/MM/YYYY)
            DateTime parsedDate;
            if (!DateTime.TryParseExact(ngaySinh, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                MessageBox.Show("Ngày sinh phải đúng định dạng DD/MM/YYYY!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giả sử cập nhật thành công (sau này bạn thay bằng code lưu DB)
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form sau khi xong
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
