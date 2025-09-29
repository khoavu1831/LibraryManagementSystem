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
    public partial class UcSach : UserControl
    {
        public UcSach()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvSach.DataSource = new List<dynamic>
            {
                new { ID = 1, TenSach = "Lập trình C#", Nam = 2023 },
                new { ID = 2, TenSach = "Cơ sở dữ liệu", Nam = 2022 }
            };
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
