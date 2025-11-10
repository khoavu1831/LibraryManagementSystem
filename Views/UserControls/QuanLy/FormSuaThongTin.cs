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
using LMS.Helpers;
using Microsoft.EntityFrameworkCore;

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
            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!");
                return;
            }

            using (var db = new LibraryDbContext())
            {
                var nv = db.NhanViens
                           .FirstOrDefault(x => x.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                if (nv != null)
                {
                    txtTen.Text = nv.TenNhanVien;
                    txtNgaySinh.Text = nv.NgaySinh.ToString("yyyy-MM-dd");
                    txtDiaChi.Text = nv.DiaChi;
                    txtGioiTinh.Text = nv.GioiTinh;
                    txtSDT.Text = nv.SDT;
                    txtEmail.Text = nv.Email;
                    txtVaiTro.Text = nv.TaiKhoan?.VaiTro?.TenVaiTro ?? " ";
                }
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (CurrentUserContext.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập!");
                return;
            }

            using (var db = new LibraryDbContext())
            {
                var nv = db.NhanViens
                           .FirstOrDefault(x => x.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                if (nv != null)
                {
                    nv.TenNhanVien = txtTen.Text;
                    nv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                    nv.DiaChi = txtDiaChi.Text;
                    //nv.GioiTinh = txtGioiTinh.Text;
                    nv.SDT = txtSDT.Text;
                    nv.Email = txtEmail.Text;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên để cập nhật!");
                }
            }
        }

    }
}
