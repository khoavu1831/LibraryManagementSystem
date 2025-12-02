using LMS.Data;
using LMS.Entities;
using LMS.Services;
namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    public partial class UcKhachHang : UserControl
    {
        private readonly LibraryDbContext _context;
        private readonly DocGiaService _docGiaService;
        private int _pageSize = 15;
        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string _currentKeyword = "";
        public UcKhachHang(List<string> permissions)
        {
            InitializeComponent();
            dgvKhachHang.EnableHeadersVisualStyles = false; // Cho phép đổi màu
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            try
            {
                // Khởi tạo DbContext và repository
                _context = new LibraryDbContext();
                var docGiaRepo = new Repository.DocGiaRepository(_context);
                var theThanhVienRepo = new Repository.TheThanhVienRepository(_context);

                // Khởi tạo service với transaction
                _docGiaService = new DocGiaService(_context, docGiaRepo, theThanhVienRepo);

                LoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến database\n[{ex.Message}]",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvKhachHang.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            var canAdd = permissions.Contains("KHACHHANG_ADD");
            var canEdit = permissions.Contains("KHACHHANG_EDIT");
            var canDelete = permissions.Contains("KHACHHANG_DELETE");
            var canViewDetails = permissions.Contains("KHACHHANG_VIEW");
            var canExport = permissions.Contains("KHACHHANG_EXPORT");
            btnThem.Visible = canAdd;
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;
            btnChiTiet.Visible = canViewDetails;
            btnExcel.Visible = canExport;

        }

        private void LoadPage(int page, string keyword = "")
        {
            _currentPage = page;
            _currentKeyword = keyword;
            try
            {
                _totalRecords = _docGiaService.getCount(_currentKeyword);
                _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);
                var data = _docGiaService.GetByPage(_currentPage, _pageSize, _currentKeyword);

                if (data.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy độc giả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPage(1);
                    return;
                }

                dgvKhachHang.DataSource = data;

                if (dgvKhachHang.Columns["TheThanhViens"] != null)
                    dgvKhachHang.Columns["TheThanhViens"].Visible = false;
                dgvKhachHang.Columns["IdDocGia"].HeaderText = "Mã độc giả";
                dgvKhachHang.Columns["TenDocGia"].HeaderText = "Tên độc giả";
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvKhachHang.AutoGenerateColumns = true;
                labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lấy danh sách độc giả thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LoadData()
        {
            LoadPage(1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                using var formThem = new FormThemKhachHang(_docGiaService);
                if (formThem.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 độc giả để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvKhachHang.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IdDocGia"].Value);
            string ten = row.Cells["TenDocGia"].Value.ToString() ?? "";
            string diaChi = row.Cells["DiaChi"].Value.ToString() ?? "";
            DateTime ngaySinh = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString() ?? "");
            string sdt = row.Cells["SDT"].Value.ToString() ?? "";
            string email = row.Cells["Email"].Value.ToString() ?? "";

            using var formSua = new FormSuaKhachHang(_docGiaService, id, ten, diaChi, ngaySinh, sdt, email);
            if (formSua.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 độc giả để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvKhachHang.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IdDocGia"].Value);

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _docGiaService.DeleteDocGia(id);
                MessageBox.Show("Xóa độc giả thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa độc giả thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 độc giả để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvKhachHang.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["IdDocGia"].Value);
            string ten = row.Cells["TenDocGia"].Value.ToString() ?? "";
            string diaChi = row.Cells["DiaChi"].Value.ToString() ?? "";
            DateTime ngaySinh = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString() ?? "");
            string sdt = row.Cells["SDT"].Value.ToString() ?? "";
            string email = row.Cells["Email"].Value.ToString() ?? "";

            using var formChiTiet = new FormChiTietKhachHang(id, ten, diaChi, ngaySinh, sdt, email);
            formChiTiet.ShowDialog(this);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBoxTimKiem.Text = "";
            _currentKeyword = "";
            LoadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var data = _docGiaService.GetAllDocGia().ToList();
            var stream = LMS.Utils.Helpers.ExportExcel.Export<DocGia>(data, "doc gia", ["TheThanhViens"]);
            stream.Position = 0; // reset stream về đầu

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "DocGia.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
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
