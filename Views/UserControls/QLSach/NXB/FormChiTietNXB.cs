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

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormChiTietNXB : Form
    {
        private readonly int _idNXB;
        public FormChiTietNXB(int idNXB, string tenNXB, string diaChi, string sdt)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            _idNXB = idNXB;
            textBoxIdNXB.Text = idNXB.ToString();
            textBoxTenNXB.Text = tenNXB;
            textBoxDiaChi.Text = diaChi;
            textBoxSDT.Text = sdt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
