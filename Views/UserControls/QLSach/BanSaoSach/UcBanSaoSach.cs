using LMS.Data;
using LMS.Helpers;
using LMS.Models.Dtos;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcBanSaoSach : UserControl
    {
        private int _pageSize = 15;

        private int _currentPage = 1;
        private int _totalRecords = 0;
        private int _totalPages = 0;
        private string _currentKeyword = "";
        public UcBanSaoSach(List<string> permissions)
        {
            InitializeComponent();
            var canEdit = permissions.Contains("SACH_BANSAO_EDIT");
            var canDelete = permissions.Contains("SACH_BANSAO_DELETE");
            btnSua.Visible = canEdit;
            btnXoa.Visible = canDelete;

            dgvBanSaoSach.EnableHeadersVisualStyles = false; // Cho phép đổi màu
            dgvBanSaoSach.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvBanSaoSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBanSaoSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            
            LoadData();
        }

        private void LoadData()
        {
            LoadPage(1);
        }
        private void LoadPage(int page, string keyword = "")
        {
            _currentPage = page;
            _currentKeyword = keyword;

            using (var context = new LibraryDbContext())
            {
                var repo = new BanSaoSachRepository(context);
                var bssService = new BanSaoSachService(repo);

                _totalRecords = bssService.GetTotalRecords(_currentKeyword);
                _totalPages = (int)Math.Ceiling(_totalRecords / (double)_pageSize);

                var bssList = bssService.GetBanSaoSachByPage(_currentPage, _pageSize, _currentKeyword);

                var bssDataView = bssList.Select(bss => new
                {
                    IdBanSaoSach = bss.IdBanSaoSach,
                    IdSach = bss.IdSach,
                    TenSach = bss.Sach!.TenSach,
                    TrangThai = bss.TinhTrangSach.GetDisplayName()
                }).ToList();

                if (bssDataView.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bản sao sách phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPage(1);
                    return;
                }
                dgvBanSaoSach.DataSource = bssDataView;

                labelTrang.Text = $"Trang {_currentPage}/{_totalPages}";

                dgvBanSaoSach.Columns["IdBanSaoSach"].HeaderText = "Mã bản sao sách";
                dgvBanSaoSach.Columns["IdSach"].HeaderText = "Mã sách";
                dgvBanSaoSach.Columns["TenSach"].HeaderText = "Tên sách";
                dgvBanSaoSach.Columns["TrangThai"].HeaderText = "Trạng thái";
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaBSS = new FormSuaBSS())
            {
                formSuaBSS.ShowDialog(this);
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

            _currentPage = 1; // reset về trang 1 khi tìm kiếm
            LoadPage(_currentPage, keyword);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBoxTimKiem.Text = "";
            _currentKeyword = "";
            LoadPage(1);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new BanSaoSachRepository(context);
                    var bssService = new BanSaoSachService(repo);

                    // Lấy dữ liệu
                    var data = bssService.GetListExport();


                    // Xuất Excel
                    var stream = LMS.Utils.Helpers.ExportExcel.Export<BanSaoSachExcelDto>(
                        data,
                        "ban sao sach",
                        new string[] { "" }
                    );

                    stream.Position = 0;

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Workbook|*.xlsx";
                        sfd.FileName = "BanSaoSach.xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (var fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                            {
                                stream.CopyTo(fileStream);
                            }
                            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất Excel thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
