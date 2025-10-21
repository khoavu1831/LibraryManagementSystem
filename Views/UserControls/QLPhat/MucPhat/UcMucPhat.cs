using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using Microsoft.EntityFrameworkCore;
using LMS.Repository;
using LMS.Services;
using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLPhat
{
    public partial class UcMucPhat : UserControl
    {
        public UcMucPhat()
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
                    var repo = new MucPhatRepository(context);
                    var mucPhatService = new MucPhatService(repo);
                    var mucPhatList = mucPhatService.GetAllMucPhat();

                    var mucPhatDataView = mucPhatList.Select(mp => new
                    {
                        IdMucPhat = mp.IdMucPhat,
                        TenMucPhat = mp.TenMucPhat,
                        SoTienPhat = mp.SoTienPhat,
                        MoTa = mp.MoTa,
                        LoaiPhat = mp.LoaiPhat.GetDisplayName() // Hiển thị có dấu
                    }).ToList();

                    dgvMucPhat.AutoGenerateColumns = true;
                    dgvMucPhat.DataSource = mucPhatDataView;
                    dgvMucPhat.Columns["IdMucPhat"].HeaderText = " Mã Mức Phạt";
                    dgvMucPhat.Columns["TenMucPhat"].HeaderText = "Tên Mức Phạt";
                    dgvMucPhat.Columns["SoTienPhat"].HeaderText = "Số Tiền Phạt";
                    dgvMucPhat.Columns["MoTa"].HeaderText = "Mô Tả";
                    dgvMucPhat.Columns["LoaiPhat"].HeaderText = "Loại Phạt";

                    dgvMucPhat.EnableHeadersVisualStyles = false;
                    dgvMucPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                    dgvMucPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvMucPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemMucPhat = new FormThemMucPhat())
            {
                if (formThemMucPhat.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMucPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 mức phạt để sửa", "Thông báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvMucPhat.SelectedRows[0];
            int idMucPhat = Convert.ToInt32(selectedRow.Cells["IdMucPhat"].Value);
            string tenMucPhat = selectedRow.Cells["TenMucPhat"].Value.ToString() ?? "";
            decimal soTienPhat = Convert.ToDecimal(selectedRow.Cells["SoTienPhat"].Value);
            string moTa = selectedRow.Cells["MoTa"].Value?.ToString() ?? "";
            
            // Parse string về enum - cần vì DataGridView hiển thị string có dấu
            string loaiPhatDisplay = selectedRow.Cells["LoaiPhat"].Value.ToString() ?? "";
            
            // Tìm enum value tương ứng
            var loaiPhat = Enum.GetValues(typeof(MucPhat.LoaiPhatEnum))
                .Cast<MucPhat.LoaiPhatEnum>()
                .FirstOrDefault(e => e.GetDisplayName() == loaiPhatDisplay);

            using (var formSuaMucPhat = new FormSuaMucPhat(idMucPhat, tenMucPhat, soTienPhat, moTa, loaiPhat))
            {
                if (formSuaMucPhat.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMucPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 mức phạt để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvMucPhat.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa mức phạt này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idMucPhat = Convert.ToInt32(selectedRow.Cells["IdMucPhat"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new MucPhatRepository(context);
                        var mucPhatService = new MucPhatService(repo);
                        mucPhatService.DeleteMucPhat(idMucPhat);
                    }
                    MessageBox.Show("Xóa mức phạt thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa mức phạt thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvMucPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 mức phạt để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvMucPhat.SelectedRows[0];
            int idMucPhat = Convert.ToInt32(selectedRow.Cells["IdMucPhat"].Value);
            string tenMucPhat = selectedRow.Cells["TenMucPhat"].Value.ToString() ?? "";
            decimal soTienPhat = Convert.ToDecimal(selectedRow.Cells["SoTienPhat"].Value);
            string moTa = selectedRow.Cells["MoTa"].Value.ToString() ?? "";
            Enum.TryParse(selectedRow.Cells["LoaiPhat"].Value.ToString(), out MucPhat.LoaiPhatEnum loaiPhat);

            using (var formChiTietMucPhat = new FormChiTietMucPhat(idMucPhat, tenMucPhat, loaiPhat, moTa, soTienPhat))
            {
                if (formChiTietMucPhat.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
            
            // Kiểm tra nếu không nhập gì
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Cảnh báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus(); // Focus vào textbox để người dùng nhập
                return;
            }
            
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new MucPhatRepository(context);
                    var mucPhatService = new MucPhatService(repo);

                    var data = mucPhatService.SearchMucPhat(keyword);
                    
                    // Hiển thị có dấu cho loại phạt trong kết quả tìm kiếm
                    var mucPhatDataView = data.Select(mp => new
                    {
                        IdMucPhat = mp.IdMucPhat,
                        TenMucPhat = mp.TenMucPhat,
                        SoTienPhat = mp.SoTienPhat,
                        MoTa = mp.MoTa,
                        LoaiPhat = mp.LoaiPhat.GetDisplayName()
                    }).ToList();
                    
                    if (mucPhatDataView.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Không cần set DataSource nếu không có kết quả
                    }
                    
                    dgvMucPhat.DataSource = mucPhatDataView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tìm kiếm thất bại.\n{ex.Message}", "Lỗi", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMucPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
