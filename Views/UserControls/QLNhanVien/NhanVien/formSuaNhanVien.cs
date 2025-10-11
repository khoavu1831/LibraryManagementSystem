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

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class FormSuaNhanVien : Form
    {
        private readonly int _idNhanVien;
        private readonly int _idTaiKhoan;
        private readonly LibraryDbContext _context;
        private readonly NhanVienService _nhanVienService;
        public FormSuaNhanVien(string idNhanVien, string tenNhanVien, string ngaySinh, string diaChi, string sdt, string email)
        {
            InitializeComponent();
            _idNhanVien = int.Parse(idNhanVien);
            textBoxHVT.Text = tenNhanVien;
            textBoxNS.Text = ngaySinh;
            textBoxDC.Text = diaChi;
            textBoxSDT.Text = sdt;
            textBoxEmail.Text = email;
            _context = new LibraryDbContext(); 
            var repo = new NhanVienRepository(_context);
            _nhanVienService = new NhanVienService(repo);
            var nhanVienID = _nhanVienService.GetNhanVienById(_idNhanVien);
            _idTaiKhoan = nhanVienID.IdTaiKhoan;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenNhanVien = textBoxHVT.Text.Trim();
            var ngaySinh = textBoxNS.Text.Trim();
            var diaChi = textBoxDC.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();
            var email = textBoxEmail.Text.Trim();

            var nhanVien = _context.NhanViens.FirstOrDefault(x => x.IdNhanVien == _idNhanVien);
            if (nhanVien != null)
            {
                nhanVien.TenNhanVien = tenNhanVien;
                nhanVien.NgaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null);
                nhanVien.DiaChi = diaChi;
                nhanVien.SDT = sdt;
                nhanVien.Email = email;

                _context.SaveChanges();
                MessageBox.Show("Sửa thông tin nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
