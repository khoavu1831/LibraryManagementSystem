using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    public partial class UcNhapSach : UserControl
    {
        public UcNhapSach()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuNhapRepository(context);
                    var pnService = new PhieuNhapService(repo);
                    var pnDataView = pnService.GetAllPhieuNhap().Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC != null ? pn.NCC.TenNCC : "Chua co",
                        TenNhanVien = pn.NhanVien != null ? pn.NhanVien.TenNhanVien : "Chua co",
                        LoaiPhieuNhap = pn.LoaiPhieuNhap
                    }).ToList();

                    dgvPhieuNhap.DataSource = pnDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuNhap = new FormThemPhieuNhap())
            {
                formThemPhieuNhap.ShowDialog(this);
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
            // using (var formChiTietSach = new FormChiTietSach())
            // {
            //     formChiTietSach.ShowDialog(this);
            // }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new SachRepository(context);
                    var sachService = new SachService(repo);
                    var sach = sachService.GetAllSach();
                    var chonSach = sach.Where(s => s.SoLuongBanSao == 0).ToList();
                    MessageBox.Show(string.Join(", ", chonSach.Select(s => s.TenSach)));                 
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
