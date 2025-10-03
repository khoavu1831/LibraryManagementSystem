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
            if (string.IsNullOrWhiteSpace(textBoxTenNXB.Text))
            {
                MessageBox.Show("Tên NXB không được để trống.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxSDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số \nvà bắt đầu bằng 0.",
                    "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nxb = new NXB
            {
                TenNXB = textBoxTenNXB.Text,
                DiaChi = textBoxDiaChi.Text,
                SDT = textBoxSDT.Text
            };

            try
            {
                _nxbService.AddNXB(nxb);
                MessageBox.Show("Thêm NXB thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm NXB: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
