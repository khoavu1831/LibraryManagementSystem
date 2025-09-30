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
    public partial class UcTacGia : UserControl
    {
        public UcTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemTacGia = new FormThemTacGia())
            {
                formThemTacGia.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaTacGia = new FormSuaTacGia())
            {
                formSuaTacGia.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietTacGia = new FormChiTietTacGia())
            {
                formChiTietTacGia.ShowDialog(this);
            }
        }
    }
}
