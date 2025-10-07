using LibraryManagementSystem.Views.UserControls.QLNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach.Nhap
{
    public partial class UcNhap : UserControl
    {
        public UcNhap()
        {
            InitializeComponent();
        }

        private void btnQLNhap_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemNhapsach formThemNhapsach = new FormThemNhapsach();
            formThemNhapsach.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSuaNhapsach FormSuaNhapsach = new FormSuaNhapsach();
            FormSuaNhapsach.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCTNhapsach FormCTNhapsach = new FormCTNhapsach();
            FormCTNhapsach.Show();
        }

        private void UcNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
