using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach.NCC
{
    public partial class UcNCC : UserControl
    {
        public UcNCC()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemNCC FormThemNCC = new FormThemNCC();
            FormThemNCC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSuaNCC FormSuaNCC = new FormSuaNCC();
            FormSuaNCC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormXoaNCC FormXoaNCC = new FormXoaNCC();
            FormXoaNCC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCTNCC FormCTNCC = new FormCTNCC();
            FormCTNCC.Show();
        }
    }
}
