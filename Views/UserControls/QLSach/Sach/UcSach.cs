using LibraryManagementSystem.Views.UserControls.QLSach;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemSach = new FormThemSach())
            {
                formThemSach.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaSach = new FormSuaSach())
            {
                formSuaSach.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietSach = new FormChiTietSach())
            {
                formChiTietSach.ShowDialog(this);
            }
        }
    }
}
