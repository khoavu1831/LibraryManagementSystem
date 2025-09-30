using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class UcNXB : UserControl
    {
        public UcNXB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemNXB = new FormThemNXB())
            {
                formThemNXB.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaNXB = new FormSuaNXB())
            {
                formSuaNXB.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietNXB = new FormChiTietNXB())
            {
                formChiTietNXB.ShowDialog(this);
            }
        }
    }
}
