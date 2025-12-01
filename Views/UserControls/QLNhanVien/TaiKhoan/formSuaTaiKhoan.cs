using LMS.Data;
using LMS.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LMS.Views.UserControls.QLNhanVien.TaiKhoan
{
    public partial class FormSuaTaiKhoan : Form
    {
        private string _idTaiKhoan;
        private readonly VaiTroService _vaiTroService;
        public FormSuaTaiKhoan(string idTaiKhoan, string tenDangNhap, string matKhau)
        {
            InitializeComponent();
    
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxHVT.Text = tenDangNhap;
            textBoxMK.Text = matKhau;
            _idTaiKhoan = idTaiKhoan;
            using (var context = new LibraryDbContext())
            {
                var repoTaiKhoan = new Repository.TaiKhoanRepository(context);
                var taiKhoanService = new Services.TaiKhoanService(repoTaiKhoan);
                var TaiKhoan = taiKhoanService.GetTaiKhoanById(int.Parse(_idTaiKhoan));

                var repo = new Repository.VaiTroRepository(context);
                _vaiTroService = new Services.VaiTroService(repo);
                var vaiTroId = _vaiTroService.GetVaiTroById(TaiKhoan.IdVaiTro);
                LoadVaiTro();
                comboBoxVT.SelectedValue = TaiKhoan.IdVaiTro;
            }
        }

        public void LoadVaiTro()
        {
            var listVaiTro = _vaiTroService.GetAllVaiTro();

            comboBoxVT.DataSource = listVaiTro;
            comboBoxVT.DisplayMember = "TenVaiTro";
            comboBoxVT.ValueMember = "IdVaiTro";
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenDangNhap = textBoxHVT.Text.Trim();
            var matKhau = textBoxMK.Text.Trim();
            using (var context = new LibraryDbContext())
            {
                var repoTaiKhoan = new Repository.TaiKhoanRepository(context);
                var taiKhoanService = new Services.TaiKhoanService(repoTaiKhoan);
                var taiKhoan = taiKhoanService.GetTaiKhoanById(int.Parse(_idTaiKhoan));
                if (taiKhoan != null)
                {
                    taiKhoan.TenTaiKhoan = tenDangNhap;
                    taiKhoan.MatKhau = matKhau;
                    taiKhoan.IdVaiTro = (int)comboBoxVT.SelectedValue;
                    try
                    {
                        taiKhoanService.UpdateTaiKhoan(taiKhoan);
                        MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }


            }
        }
    }
}
