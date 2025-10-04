using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    public partial class UcMuonSach : UserControl
    {
        public UcMuonSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvMuonSach.DataSource = new List<dynamic>
            {
                new { ID = 1, TenSach = "Lập trình C#", NgayMuon = new DateTime(2025, 1, 12), HanTra = new DateTime(2025, 1, 26) },
                new { ID = 2, TenSach = "Cơ sở dữ liệu", NgayMuon = new DateTime(2025, 2, 5), HanTra = new DateTime(2025, 2, 20) },
                new { ID = 3, TenSach = "Cấu trúc dữ liệu", NgayMuon = new DateTime(2025, 3, 18), HanTra = new DateTime(2025, 4, 2) },
                new { ID = 10, TenSach = "Học máy", NgayMuon = new DateTime(2025, 10, 15), HanTra = new DateTime(2025, 10, 30) }
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemMuon = new FormThemMuonSach())
            {
                formThemMuon.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSua = new FormSuaMuonSach())
            {
                formSua.ShowDialog(this);
            }

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietMuon = new FormChiTietMuonSach())
            {
                formChiTietMuon.ShowDialog(this);
            }
        }
    }
}
