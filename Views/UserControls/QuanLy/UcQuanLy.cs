using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Helpers; // để nhận CurrentUserContext
using LMS.Data;//  để nhận LibraryDbContext
using Microsoft.EntityFrameworkCore;
using LMS.Views.Views.UserControls.QuanLy; // để dùng Include()

namespace LMS.Views.UserControls.QuanLy
{
    public partial class UcQuanLy : UserControl
    {
        public UcQuanLy()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaThongTin formSua = new FormSuaThongTin();
            formSua.ShowDialog();
            UcQuanLy_Load_1(sender, e);
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoi = new FormDoiMatKhau();
            formDoi.ShowDialog();

        }
 

        private void UcQuanLy_Load_1(object sender, EventArgs e)
        {
            if (CurrentUserContext.CurrentUser == null)
                return;

            using (var db = new LibraryDbContext())
            {
                var nv = db.NhanViens
                           .Include(n => n.TaiKhoan)
                           .Include(n => n.TaiKhoan.VaiTro)
                           .FirstOrDefault(n => n.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                if (nv != null)
                {
                    txtTen.Text = nv.TenNhanVien;
                    txtNgaySinh.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
                    txtDiaChi.Text = nv.DiaChi;
                    txtGioiTinh.Text = nv.GioiTinh ?? "";
                    txtSDT.Text = nv.SDT;
                    txtEmail.Text = nv.Email;
                    txtVaiTro.Text = nv.TaiKhoan?.VaiTro?.TenVaiTro ?? "";
                }
            }
        }
    }
}
