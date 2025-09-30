using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.TaiKhoan
{
    public partial class UcTaiKhoan : UserControl
    {
        public UcTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaTaiKhoan formSuaTaiKhoan = new FormSuaTaiKhoan();
            formSuaTaiKhoan.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietTaiKhoan formChiTietTaiKhoan = new FormChiTietTaiKhoan();
            formChiTietTaiKhoan.Show();
        }
    }
}
