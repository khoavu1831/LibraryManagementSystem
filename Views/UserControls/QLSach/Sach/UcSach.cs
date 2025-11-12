using LMS.Data;
using LMS.Entities;
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

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcSach : UserControl
    {
        public UcSach(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("SACH_ADD");
            var canEdit = permissions.Contains("SACH_EDIT");
            var canDelete = permissions.Contains("SACH_DELETE");
            var canViewDetails = permissions.Contains("SACH_VIEW");
            btnThem.Enabled = canAdd;
            btnSua.Enabled = canEdit;
            btnXoa.Enabled = canDelete;
            btnChiTiet.Enabled = canViewDetails;

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new SachRepository(context);
                    var sachService = new SachService(repo);
                    var sachList = sachService.GetAllSach();

                    var sachDataView = sachList.Select(s => new
                    {
                        IdSach = s.IdSachFormat,
                        TenSach = s.TenSach,
                        NXB = s.NXB != null ? s.NXB.TenNXB : "Chua co",
                        TheLoai = s.TheLoais != null ? string.Join(", ", s.TheLoais.Select(tl => tl.TenTheloai)) : "Chua co",
                        TacGia = s.TacGias != null ? string.Join(", ", s.TacGias.Select(tg => tg.TenTacGia)) : "Chua co",
                        NamXuatBan = s.NamXuatBan,
                        SoLuongBanSao = s.SoLuongBanSao
                    }).ToList();

                    dgvSach.DataSource = sachDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemSach = new FormThemSach())
            {
                if (formThemSach.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
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
            var context = new LibraryDbContext();
            var repo = new SachRepository(context);
            var sachService = new SachService(repo);

            if (dgvSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 sách để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvSach.SelectedRows[0];

            string idSachFormat = selectedRow.Cells["IdSach"].Value.ToString()!;
            int idSach = Convert.ToInt32(idSachFormat.Substring(1));
            string tenSach = selectedRow.Cells["TenSach"].Value.ToString() ?? "";
            string theLoai = selectedRow.Cells["TheLoai"].Value.ToString() ?? "";
            string tacGia = selectedRow.Cells["TacGia"].Value.ToString() ?? "";
            string nxb = selectedRow.Cells["NXB"].Value.ToString() ?? "";
            int namXuatBan = Convert.ToInt32(selectedRow.Cells["NamXuatBan"].Value);
            int soLuongBanSao = Convert.ToInt32(selectedRow.Cells["SoLuongBanSao"].Value);
            string moTa = sachService.GetSachById(idSach)!.MoTa!;
            int soTrang = Convert.ToInt32(sachService.GetSachById(idSach)!.SoTrang);
            decimal giaTien = Convert.ToDecimal(sachService.GetSachById(idSach)!.GiaTien);

            using (var formChiTietSach = new FormChiTietSach(idSachFormat, tenSach, theLoai, tacGia, nxb, namXuatBan, moTa, soTrang, soLuongBanSao, giaTien))
            {
                if (formChiTietSach.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
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
