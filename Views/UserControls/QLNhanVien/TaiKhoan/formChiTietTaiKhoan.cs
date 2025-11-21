using LMS.Data;
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
    public partial class FormChiTietTaiKhoan : Form
    {
        private string _idTaiKhoan;
        public FormChiTietTaiKhoan(string idTaiKhoan, string tenDangNhap, string matKhau)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
