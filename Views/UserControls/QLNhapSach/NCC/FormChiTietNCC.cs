using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class FormChiTietNCC : Form
    {
        public FormChiTietNCC(int idNCC, string tenNCC, string diaChi, string sdt)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxIdNCC.Text = idNCC.ToString();
            textBoxTenNCC.Text = tenNCC;
            textBoxDiaChi.Text = diaChi;
            textBoxSDT.Text = sdt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
