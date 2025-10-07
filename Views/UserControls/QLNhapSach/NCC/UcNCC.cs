﻿using LibraryManagementSystem.Data;
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

namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    public partial class UcNCC : UserControl
    {
        public UcNCC()
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
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);
                    var data = nccService.GetAllNCC();
                    dgvNCC.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemNCC = new FormThemNCC())
            {
                if (formThemNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NCC để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
            string tenNCC = selectedRow.Cells["TenNCC"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formSuaNCC = new FormSuaNCC(idNCC, tenNCC, diaChi, sdt))
            {
                if (formSuaNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 NCC để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
            string tenNCC = selectedRow.Cells["TenNCC"].Value.ToString() ?? "";
            string diaChi = selectedRow.Cells["DiaChi"].Value.ToString() ?? "";
            string sdt = selectedRow.Cells["SDT"].Value.ToString() ?? "";

            using (var formChiTietNCC = new FormChiTietNCC(idNCC, tenNCC, diaChi, sdt))
            {
                if (formChiTietNCC.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvNCC.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idNCC = Convert.ToInt32(selectedRow.Cells["IdNCC"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new NCCRepository(context);
                        var nccService = new NCCService(repo);
                        nccService.DeleteNCC(idNCC);
                    }

                    MessageBox.Show("Xóa nhà cung cấp thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa nhà cung cấp thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (var context = new LibraryDbContext())
                {
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);

                    var data = nccService.SearchNCC(keyword);
                    if (data.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvNCC.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
