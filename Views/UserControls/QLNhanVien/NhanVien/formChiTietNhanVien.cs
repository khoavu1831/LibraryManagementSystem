using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class FormChiTietNhanVien : Form
    {
        public FormChiTietNhanVien(string idNhanVien, string tenNhanVien,string ngaySinh, string diaChi, string sdt, string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxHVT.Text = tenNhanVien;
            textBoxNS.Text = ngaySinh;
            textBoxDC.Text = diaChi;
            textBoxSDT.Text = sdt;
            textBoxEmail.Text = email;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
