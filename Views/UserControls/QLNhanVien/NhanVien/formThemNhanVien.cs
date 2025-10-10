using LibraryManagementSystem.Data;
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

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien
{
    public partial class FormThemNhanVien : Form
    {
        private readonly NhanVienService _nhanVienService;
        private readonly TaiKhoanService _taiKhoanService;
        public FormThemNhanVien()
        {
            InitializeComponent();
            var context = new LibraryDbContext();

            var nhanVienRepo = new NhanVienRepository(context);
            _nhanVienService = new NhanVienService(nhanVienRepo);
            var taiKhoanRepo = new TaiKhoanRepository(context);
            _taiKhoanService = new TaiKhoanService(taiKhoanRepo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void formThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenNhanVien = textBoxHVT.Text;
            string taiKhoan = textBoxTK.Text;
            string matKhau = textBoxMK.Text;
            //DateTime ngaySinh = dateTimePickerNS.Value;
            string diaChi = textBoxDC.Text;
            string sdt = textBoxSDT.Text;
            string email = textBoxEmail.Text;

            _taiKhoanService.AddTaiKhoan(new Entities.TaiKhoan());

        }
    }
}
