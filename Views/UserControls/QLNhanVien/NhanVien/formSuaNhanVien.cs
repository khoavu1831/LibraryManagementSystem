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

namespace LMS.Views.UserControls.QLNhanVien.NhanVien
{
    public partial class FormSuaNhanVien : Form
    {
        private readonly int _idNhanVien;
        private readonly NhanVienService _nhanVienService;
        public FormSuaNhanVien(string idNhanVien, string tenNhanVien, string ngaySinh, string diaChi, string sdt, string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            _idNhanVien = int.Parse(idNhanVien);
            textBoxHVT.Text = tenNhanVien;
            DateTime ngaySinhDate = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null);
            dateTimePickerNV.Value = ngaySinhDate;
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
            DateTime ngaySinh = dateTimePickerNV.Value;
            var diaChi = textBoxDC.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            try
            {
                _nhanVienService.UpdateNhanVien(new Entities.NhanVien
                {
                    IdNhanVien = _idNhanVien,
                    TenNhanVien = textBoxHVT.Text.Trim(),
                    NgaySinh = ngaySinh,
                    DiaChi = textBoxDC.Text.Trim(),
                    SDT = textBoxSDT.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),

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
