using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using System.Text.RegularExpressions;
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
    public partial class FormThemNXB : Form
    {
        private readonly NXBService _nxbService;
        public FormThemNXB()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var nxbRepository = new NXBRepository(context);
            _nxbService = new NXBService(nxbRepository);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenNXB = textBoxTenNXB.Text.Trim();
            var diaChi = textBoxDiaChi.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                var nxb = new NXB
                {
                    TenNXB = tenNXB,
                    DiaChi = diaChi,
                    SDT = sdt
                };

                _nxbService.Save(nxb);

                MessageBox.Show("Thêm NXB thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
