using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Helpers;
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

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach
{
    public partial class UcMuonTraSach : UserControl
    {
        public UcMuonTraSach()
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
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    var pmList = pmService.GetAllPhieuMuon();

                    var pmDataView = pmList.Select(pm => new
                    {
                        IdPhieuMuon = pm.IdPhieuMuon,
                        TenNhanVien = pm.NhanVien != null ? pm.NhanVien.TenNhanVien : "Chưa có",
                        TenThanhVien = pm.TheThanhVien != null && pm.TheThanhVien.DocGia != null
                            ? pm.TheThanhVien.DocGia.TenDocGia
                            : "Chưa có",
                        NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                        NgayHenTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                        TrangThai = pm.TrangThai.GetDisplayName()
                    }).ToList();

                    dgvPhieuMuonTra.DataSource = pmDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu mượn\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuMuonTra = new FormThemPhieuMuonTra())
            {
                formThemPhieuMuonTra.ShowDialog(this);
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
