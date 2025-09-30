using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class UcNhanVien : UserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaNhanVien formSuaNhanVien = new FormSuaNhanVien();
            formSuaNhanVien.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietNhanVien formChiTietNhanVien = new FormChiTietNhanVien();
            formChiTietNhanVien.Show();
        }
    }
}
