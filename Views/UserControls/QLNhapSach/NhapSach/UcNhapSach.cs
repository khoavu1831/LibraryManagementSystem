using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcNhapSach : UserControl
    {
        public UcNhapSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("NHAPSACH_ADD");
            var canEdit = permissions.Contains("NHAPSACH_EDIT");
            var canDelete = permissions.Contains("NHAPSACH_DELETE");
            var canViewDetails = permissions.Contains("NHAPSACH_VIEW");
            var canExport = permissions.Contains("NHAPSACH_EXPORT");
            btnThem.Enabled = canAdd;
            btnChiTiet.Enabled = canViewDetails;
            btnXoa.Enabled = canDelete;
            btnLamMoi.Enabled = true;
            btnExcel.Enabled = canExport;
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
                    var pnList = pnService.GetAllPhieuNhap();

                    var pnDataView = pnList.Select(pn => new
                    {
                        IdPhieuNhap = pn.IdPhieuNhap,
                        TenNCC = pn.NCC != null ? pn.NCC.TenNCC : "Chua co",
                        TenNhanVien = pn.NhanVien != null ? pn.NhanVien.TenNhanVien : "Chua co",
                        SoLuongNhap = pn.SoLuongSach,
                        LoaiPhieuNhap = pn.LoaiPhieuNhap.GetDisplayName()
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

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnListHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
