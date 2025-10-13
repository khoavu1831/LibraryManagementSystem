﻿using LibraryManagementSystem.Data;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
namespace LibraryManagementSystem.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class UcTheThanhVien : UserControl
    {
        private readonly TheThanhVienService _theThanhVienService;

        public UcTheThanhVien()
        {
            InitializeComponent();

            try
            {
                var context = new LibraryDbContext();
                var theThanhVienRepo = new TheThanhVienRepository(context);
                _theThanhVienService = new TheThanhVienService(context, theThanhVienRepo);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            var list = _theThanhVienService.GetAllTheThanhVien();

            var dataView = list.Select(ttv => new
            {
                IdTheThanhVien = ttv.IdTheThanhVien,
                IdDocGia = ttv.IdDocGia,
                TrngThai = ttv.TrangThai.GetDisplayName(),
            }).ToList();

            dgvTheThanhVien.AutoGenerateColumns = true;
            dgvTheThanhVien.DataSource = dataView;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 thẻ thành viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTheThanhVien.SelectedRows[0];
            int idTheThanhVien = Convert.ToInt32(selectedRow.Cells["IdTheThanhVien"].Value);
            int idDocGia = Convert.ToInt32(selectedRow.Cells["IdDocGia"].Value);

            using (var formSua = new FormSuaTheThanhVien(_theThanhVienService, _theThanhVienService.GetTheThanhVienById(idTheThanhVien)))
            {
                if (formSua.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvTheThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 thẻ thành viên để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTheThanhVien.SelectedRows[0];
            int idTheThanhVien = Convert.ToInt32(selectedRow.Cells["IdTheThanhVien"].Value);
            int idDocGia = Convert.ToInt32(selectedRow.Cells["IdDocGia"].Value);

            using (var formChiTiet = new FormChiTietTheThanhVien(_theThanhVienService.GetTheThanhVienById(idTheThanhVien)))
            {
                formChiTiet.ShowDialog(this);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 thẻ thành viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTheThanhVien.SelectedRows[0];
            int idTheThanhVien = Convert.ToInt32(selectedRow.Cells["IdTheThanhVien"].Value);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thẻ thành viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _theThanhVienService.DeleteTheThanhVien(idTheThanhVien);
                    MessageBox.Show("Xóa thẻ thành viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
            try
            {
                var list = _theThanhVienService.GetAllTheThanhVien();
                var filtered = list
               .Where(t =>
                   t.IdTheThanhVien.ToString().Contains(keyword)).Select(t => new
                   {
                       t.IdTheThanhVien,
                       t.IdDocGia,
                       NgayHetHan = t.NgayHetHan.ToString("dd/MM/yyyy"),
                       TrangThai = t.TrangThai.GetDisplayName()
                   })
                .ToList();
                if (filtered.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvTheThanhVien.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
