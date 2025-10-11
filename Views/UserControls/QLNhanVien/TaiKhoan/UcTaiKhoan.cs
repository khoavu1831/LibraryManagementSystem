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

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.TaiKhoan
{
    public partial class UcTaiKhoan : UserControl
    {
        public UcTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new LibraryDbContext())
            {
                var repo = new TaiKhoanRepository(context);
                var taiKhoanService = new TaiKhoanService(repo);
                var taiKhoanList = taiKhoanService.getAllTaiKhoan();
                var taiKhoanDataView = taiKhoanList.Select(tk => new
                {
                    IdTaiKhoan = tk.IdTaiKhoan,
                    TenDangNhap = tk.TenTaiKhoan,
                    MatKhau = tk.MatKhau,

                }).ToList();
                dgvTaiKhoan.DataSource = taiKhoanDataView;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaTaiKhoan formSuaTaiKhoan = new FormSuaTaiKhoan();
            formSuaTaiKhoan.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietTaiKhoan formChiTietTaiKhoan = new FormChiTietTaiKhoan();
            formChiTietTaiKhoan.Show();
        }
    }
}
