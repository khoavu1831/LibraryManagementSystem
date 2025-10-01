using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class FormChiTietTraSach : Form
    {
        public FormChiTietTraSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblNhanVienValue.Text = "NV1 - Nguyễn A";
            lblThanhVienValue.Text = "TV101 - Lê C";
            lblNgayMuonValue.Text = DateTime.Now.AddDays(-7).ToShortDateString();
            lblHanTraValue.Text = DateTime.Now.ToShortDateString();
            lblNgayTraValue.Text = DateTime.Now.ToShortDateString();

            listBoxSach.Items.Clear();
            listBoxSach.Items.Add("Bản sao #001 - Lập trình C#");
            listBoxSach.Items.Add("Bản sao #002 - Cơ sở dữ liệu");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}