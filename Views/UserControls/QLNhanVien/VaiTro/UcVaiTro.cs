using LMS.Data;
using LMS.Entities;
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

namespace LMS.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class UcVaiTro : UserControl
    {
        public UcVaiTro(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("VAITRO_ADD");
            var canEdit = permissions.Contains("VAITRO_EDIT");
            var canDelete = permissions.Contains("VAITRO_DELETE");
            var canViewDetails = permissions.Contains("VAITRO_VIEW");
            btnThem.Visible = canAdd;
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;

            dgvVaiTro.EnableHeadersVisualStyles = false;
            dgvVaiTro.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvVaiTro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVaiTro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            LoadData();
        }

        private void LoadData()
        {
            using (var context = new LibraryDbContext())
            {
                var repo = new Repository.VaiTroRepository(context);
                var vaiTroService = new Services.VaiTroService(repo);
                var vaiTroList = vaiTroService.GetAllVaiTro();
                var vaiTroDataView = vaiTroList.Select(vt => new
                {
                    IdVaiTro = vt.IdVaiTro,
                    TenVaiTro = vt.TenVaiTro
                }).ToList();
                dgvVaiTro.DataSource = vaiTroDataView;

                dgvVaiTro.Columns["IdVaiTro"].HeaderText = "Mã vai trò";
                dgvVaiTro.Columns["TenVaiTro"].HeaderText = "Tên vai trò";
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemVaiTro formThemVaiTro = new FormThemVaiTro();
            if (formThemVaiTro.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvVaiTro.SelectedRows[0];
            int idVaiTro = Convert.ToInt32(selectedRow.Cells["IdVaiTro"].Value);
            string tenVaiTro = selectedRow.Cells["TenVaiTro"].Value.ToString() ?? "";
            using (var formSuaVaiTro = new FormSuaVaiTro(idVaiTro, tenVaiTro))
            {
                if (formSuaVaiTro.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 vai trò để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvVaiTro.SelectedRows[0];
            int idVaiTro = Convert.ToInt32(selectedRow.Cells["IdVaiTro"].Value);
            string tenVaiTro = selectedRow.Cells["TenVaiTro"].Value.ToString() ?? "";
            using (var formChiTietVaiTro = new FormChiTietVaiTro(idVaiTro, tenVaiTro))
            {
                if (formChiTietVaiTro.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 vai trò để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvVaiTro.SelectedRows[0];
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idVaiTro = Convert.ToInt32(selectedRow.Cells["IdVaiTro"].Value);
                try
                {
                    using (var context = new LibraryDbContext())
                    {
                        var repo = new VaiTroRepository(context);
                        var vaiTroService = new VaiTroService(repo);
                        vaiTroService.DeleteVaiTro(idVaiTro);
                    }

                    MessageBox.Show("Xóa vai trò thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa vai trò thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus();
                return;
            }
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new VaiTroRepository(context);
                    var vaiTroService = new VaiTroService(repo);
                    var searchResults = vaiTroService.SearchVaiTro(keyword);
                    var vaiTroDataView = searchResults.Select(vt => new
                    {
                        IdVaiTro = vt.IdVaiTro,
                        TenVaiTro = vt.TenVaiTro
                    }).ToList();

                    if (vaiTroDataView.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        return;
                    }
                    
                    dgvVaiTro.DataSource = vaiTroDataView;

                    dgvVaiTro.Columns["IdVaiTro"].HeaderText = "Mã vai trò";
                    dgvVaiTro.Columns["TenVaiTro"].HeaderText = "Tên vai trò";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tìm kiếm thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
