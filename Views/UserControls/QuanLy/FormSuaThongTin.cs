using LMS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LMS.Data;
using Microsoft.EntityFrameworkCore;


namespace LMS.Views.Views.UserControls.QuanLy
{
    public partial class FormSuaThongTin : Form
    {
        public FormSuaThongTin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            Load += FormSuaThongTin_Load;
        }

        private void FormSuaThongTin_Load(object sender, EventArgs e)
        {
            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            try
            {
                using (var db = new LibraryDbContext())
                {
                    var nv = db.NhanViens
                               .Include(n => n.TaiKhoan)
                               .ThenInclude(t => t.VaiTro)
                               .FirstOrDefault(n => n.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                    if (nv == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }

                    // Load dữ liệu vào form
                    txtHoTen.Text = nv.TenNhanVien ?? "";
                    dtpNgaySinh.Value = nv.NgaySinh == default ? DateTime.Today : nv.NgaySinh;
                    txtDiaChi.Text = nv.DiaChi ?? "";
                    txtSoDienThoai.Text = nv.SDT ?? "";
                    txtEmail.Text = nv.Email ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var hoTen = txtHoTen.Text.Trim();
            var ngaySinh = dtpNgaySinh.Value.Date;
            var diaChi = txtDiaChi.Text.Trim();
            var soDienThoai = txtSoDienThoai.Text.Trim();
            var email = txtEmail.Text.Trim();

            // Họ tên bắt buộc
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (!Regex.IsMatch(hoTen, @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
            {
                MessageBox.Show("Họ tên chỉ được chứa chữ cái, tối đa 50 ký tự!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Ngày sinh bắt buộc, không lớn hơn hôm nay
            if (ngaySinh > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            // Địa chỉ bắt buộc
            if (string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            // Số điện thoại bắt buộc
            if (string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (!Regex.IsMatch(soDienThoai,@"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng số 0!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // Email bắt buộc
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không được để trống!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                MessageBox.Show("Email không đúng định dạng!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                using (var db = new LibraryDbContext())
                {
                    var nv = db.NhanViens
                               .FirstOrDefault(n => n.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                    if (nv == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhân viên để cập nhật!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nv.TenNhanVien = hoTen;
                    nv.NgaySinh = ngaySinh;
                    nv.DiaChi = diaChi;
                    nv.SDT = soDienThoai;
                    nv.Email = email;

                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
