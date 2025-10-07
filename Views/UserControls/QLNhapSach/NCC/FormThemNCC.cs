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

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    public partial class FormThemNCC : Form
    {
        private readonly NCCService _nccService;
        public FormThemNCC()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var nccRepository = new NCCRepository(context);
            _nccService = new NCCService(nccRepository);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenNCC = textBoxTenNCC.Text.Trim();
            var diaChi = textBoxDiaChi.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                var ncc = new NCC
                {
                    TenNCC = tenNCC,
                    DiaChi = diaChi,
                    SDT = sdt
                };

                _nccService.Save(ncc);

                MessageBox.Show("Thêm NCC thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
