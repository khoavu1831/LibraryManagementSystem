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
    public partial class UcBanSaoSach : UserControl
    {
        public UcBanSaoSach()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaBSS = new FormSuaBSS())
            {
                formSuaBSS.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietBSS = new FormChiTietBSS())
            {
                formChiTietBSS.ShowDialog(this);
            }
        }
    }
}
