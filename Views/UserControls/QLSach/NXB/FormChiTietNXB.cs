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

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormChiTietNXB : Form
    {
        private readonly int _idNXB;
        public FormChiTietNXB(int idNXB, string tenNXB, string diaChi, string sdt)
        {
            InitializeComponent();

            _idNXB = idNXB;
            textBoxIdNXB.Text = idNXB.ToString();
            textBoxTenNXB.Text = tenNXB;
            textBoxDiaChi.Text = diaChi;
            textBoxSDT.Text = sdt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
