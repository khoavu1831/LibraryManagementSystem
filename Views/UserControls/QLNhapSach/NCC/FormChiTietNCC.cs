using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
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
    public partial class FormChiTietNCC : Form
    {
        public FormChiTietNCC(int idNCC, string tenNCC, string diaChi, string sdt)
        {
            InitializeComponent();

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
