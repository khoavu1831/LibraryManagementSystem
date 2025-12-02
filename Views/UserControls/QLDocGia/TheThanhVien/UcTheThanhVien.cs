using LMS.Data;
using LMS.Views.LMS.Services.Services;

namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class UcTheThanhVien : UserControl
    {
        private readonly TheThanhVienService _theThanhVienService;
        private int _pageSize = 15;

        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string _currentKeyword = "";

        public UcTheThanhVien(List<string> permissions)
        {
            InitializeComponent();
            dgvTheThanhVien.EnableHeadersVisualStyles = false; // Cho phép đổi màu
            dgvTheThanhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            dgvTheThanhVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvTheThanhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            try
            {
                var context = new LibraryDbContext();
                var theThanhVienRepo = new Repository.TheThanhVienRepository(context);
                _theThanhVienService = new TheThanhVienService(context, theThanhVienRepo);
                _theThanhVienService.GetAllTheThanhVien();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var canEdit = permissions.Contains("THETHANHVIEN_EDIT");
            var canDelete = permissions.Contains("THETHANHVIEN_DELETE");
            var canViewDetails = permissions.Contains("THETHANHVIEN_VIEW");
            btnSua.Visible = canEdit;
            btnChiTiet.Visible = canViewDetails;
            btnXoa.Visible = canDelete;
        }


        private void LoadPage(int page, string keyword = "")
        {
            _currentPage = page;
            _currentKeyword = keyword;
            try
            {
                _totalRecords = _theThanhVienService.getCount(_currentKeyword);
                _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);
                var data = _theThanhVienService.getByPage(_currentPage, _pageSize, _currentKeyword);
                if (data.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy độc giả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPage(1);
                    return;
                }
                
                dgvTheThanhVien.DataSource = data;
                dgvTheThanhVien.AutoGenerateColumns = true;
                dgvTheThanhVien.Columns["NgayCap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvTheThanhVien.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvTheThanhVien.Columns["IdTheThanhVien"].HeaderText = "Mã thẻ thành viên";
                dgvTheThanhVien.Columns["IdDocGia"].HeaderText = "Mã độc giả";
                dgvTheThanhVien.Columns["NgayCap"].HeaderText = "Ngày cấp";
                dgvTheThanhVien.Columns["NgayHetHan"].HeaderText = "Ngày hết hạn";
                dgvTheThanhVien.Columns["TrangThai"].HeaderText = "Trạng thái";


                if (dgvTheThanhVien.Columns["DocGia"] != null)
                    dgvTheThanhVien.Columns["DocGia"].Visible = false;
                if (dgvTheThanhVien.Columns["PhieuMuons"] != null)
                    dgvTheThanhVien.Columns["PhieuMuons"].Visible = false;
                labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lấy danh sách thẻ thành viên thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
        private void LoadData()
        {
            LoadPage(1);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtBoxTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTimKiem.Focus();
                return;
            }
            if (string.IsNullOrEmpty(keyword))
            {
                LoadPage(1);
                return;
            }
            LoadPage(1, keyword);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBoxTimKiem.Text = "";
            _currentKeyword = "";
            LoadData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                LoadPage(_currentPage - 1, _currentKeyword);

            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                LoadPage(_currentPage + 1, _currentKeyword);

            }
        }
    }
}
