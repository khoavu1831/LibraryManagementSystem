using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class UcTraSach : UserControl
    {
        public UcTraSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var today = DateTime.Now;

            dgvTraSach.DataSource = new List<dynamic>
            {
                new {
                    ID = 1,
                    TenSach = "Lập trình C#",
                    NgayTra = new DateTime(2025, 10, 1).ToShortDateString(),
                    HanTra = new DateTime(2025, 10, 5).ToShortDateString(),
                    TrangThai = today <= new DateTime(2025, 10, 5) ? "Đúng hạn" : "Trễ hạn"
                },
                new {
                    ID = 2,
                    TenSach = "Cơ sở dữ liệu",
                    NgayTra = new DateTime(2025, 9, 15).ToShortDateString(),
                    HanTra = new DateTime(2025, 9, 20).ToShortDateString(),
                    TrangThai = today <= new DateTime(2025, 9, 20) ? "Đúng hạn" : "Trễ hạn"
                },
                new {
                    ID = 3,
                    TenSach = "Mạng máy tính",
                    NgayTra = new DateTime(2025, 9, 25).ToShortDateString(),
                    HanTra = new DateTime(2025, 9, 22).ToShortDateString(),
                    TrangThai = today <= new DateTime(2025, 9, 22) ? "Đúng hạn" : "Trễ hạn"
                }
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThem = new FormThemTraSach())
            {
                formThem.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSua = new FormSuaTraSach())
            {
                formSua.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTiet = new FormChiTietTraSach())
            {
                formChiTiet.ShowDialog(this);
            }
        }
    }
}
