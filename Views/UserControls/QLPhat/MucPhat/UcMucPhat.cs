using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class UcMucPhat : UserControl
    {
        public UcMucPhat()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemMucPhat = new FormThemMucPhat())
            {
                formThemMucPhat.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaMucPhat = new FormSuaMucPhat())
            {
                formSuaMucPhat.ShowDialog(this);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietMucPhat = new FormChiTietMucPhat())
            {
                formChiTietMucPhat.ShowDialog(this);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
