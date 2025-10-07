using LibraryManagementSystem.Views.UserControls.QLNhanVien.NhanVien;
using LibraryManagementSystem.Views.UserControls.QLNhapSach.NCC;
using LibraryManagementSystem.Views.UserControls.QLNhapSach.Nhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    public partial class UcQLNhapSach : UserControl
    {
        public UcQLNhapSach()
        {
            InitializeComponent();
            LoadSubControl(new UcNhap());
        }
        private void LoadSubControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNhap());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNCC());
        }
      
    }
}
