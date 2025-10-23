using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class FormChiTietVaiTro : Form
    {
        public FormChiTietVaiTro(int idVaiTro, string tenVaiTro)
        {
            InitializeComponent();
            textBoxHVT.Text = tenVaiTro;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
