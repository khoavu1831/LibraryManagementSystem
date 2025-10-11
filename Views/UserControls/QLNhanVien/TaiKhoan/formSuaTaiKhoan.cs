using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.TaiKhoan
{
    public partial class FormSuaTaiKhoan : Form
    {
        private string _idTaiKhoan;
        public FormSuaTaiKhoan(string idTaiKhoan, string tenDangNhap, string matKhau)
        {
            InitializeComponent();
            textBoxHVT.Text = tenDangNhap;
            textBoxMK.Text = matKhau;
            _idTaiKhoan = idTaiKhoan;
            using (var context = new LibraryDbContext())
            {
                var repoTaiKhoan = new Repository.TaiKhoanRepository(context);
                var taiKhoanService = new Services.TaiKhoanService(repoTaiKhoan);
                var TaiKhoan = taiKhoanService.GetTaiKhoanById(int.Parse(_idTaiKhoan));

                var repo = new Repository.VaiTroRepository(context);
                var vaiTroService = new Services.VaiTroService(repo);
                var vaiTroId = vaiTroService.GetVaiTroById(TaiKhoan.IdVaiTro);

                textBoxVT.Text = vaiTroId.TenVaiTro;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenDangNhap = textBoxHVT.Text.Trim();
            var matKhau = textBoxMK.Text.Trim();
            using (var context = new LibraryDbContext())
            {
                var repoTaiKhoan = new Repository.TaiKhoanRepository(context);
                var taiKhoanService = new Services.TaiKhoanService(repoTaiKhoan);
                var taiKhoan = taiKhoanService.GetTaiKhoanById(int.Parse(_idTaiKhoan));
                if (taiKhoan != null)
                {
                    taiKhoan.TenTaiKhoan = tenDangNhap;
                    taiKhoan.MatKhau = matKhau;
                    taiKhoanService.UpdateTaiKhoan(taiKhoan);
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
        }
    }
}
