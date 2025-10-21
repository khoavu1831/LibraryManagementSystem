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

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class FormSuaNhanVien : Form
    {
        private readonly int _idNhanVien;
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
            var context = new LibraryDbContext();
            var repo = new NhanVienRepository(context);
            _nhanVienService = new NhanVienService(repo);
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

            try
            {
                _nhanVienService.UpdateNhanVien(new Entities.NhanVien
                {
                    IdNhanVien = _idNhanVien,
                    TenNhanVien = textBoxHVT.Text.Trim(),
                    NgaySinh = DateTime.ParseExact(textBoxNS.Text.Trim(), "dd/MM/yyyy", null),
                    DiaChi = textBoxDC.Text.Trim(),
                    SDT = textBoxSDT.Text.Trim(),
                    Email = textBoxEmail.Text.Trim()
                });

                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
