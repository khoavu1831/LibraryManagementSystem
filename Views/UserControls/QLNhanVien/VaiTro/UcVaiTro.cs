using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class UcVaiTro : UserControl
    {
        public UcVaiTro()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemVaiTro formThemVaiTro = new FormThemVaiTro();
            formThemVaiTro.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaVaiTro formSuaVaiTro = new FormSuaVaiTro();
            formSuaVaiTro.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietVaiTro formChiTietVaiTro = new FormChiTietVaiTro();
            formChiTietVaiTro.Show();
        }
    }
}
