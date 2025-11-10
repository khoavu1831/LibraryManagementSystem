using LMS.Data;
using LMS.Services;

namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    public partial class UcKhachHang : UserControl
    {
        private readonly LibraryDbContext _context;
        private readonly DocGiaService _docGiaService;

        public UcKhachHang()
        {
            InitializeComponent();

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
        }

        private void LoadData()
        {
            var docGiaList = _docGiaService.GetAllDocGia();
            //dgvKhachHang.DataSource = docGiaList.Select(dg => new
            //{
            //    IdDocGia = dg.IdDocGia,
            //    TenDocGia = dg.TenDocGia,
            //    DiaChi = dg.DiaChi,
            //    NgaySinh = dg.NgaySinh.ToString("dd/MM/yyyy"),
            //    SDT = dg.SDT,
            //    Email = dg.Email
            //}).ToList();
            dgvKhachHang.DataSource = docGiaList;


            dgvKhachHang.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvKhachHang.Columns["TheThanhViens"] != null)
                dgvKhachHang.Columns["TheThanhViens"].Visible = false;
            dgvKhachHang.AutoGenerateColumns = true;
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
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            try
            {
                var data = _docGiaService.GetAllDocGia()
                    .Where(d => d.TenDocGia.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                d.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                d.SDT.Contains(keyword))
                    .Select(d => new
                    {
                        IdDocGia = d.IdDocGia,
                        TenDocGia = d.TenDocGia,
                        DiaChi = d.DiaChi,
                        NgaySinh = d.NgaySinh.ToString("dd/MM/yyyy"),
                        SDT = d.SDT,
                        Email = d.Email
                    })
                    .ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvKhachHang.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tìm kiếm thất bại.\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadData();

        }
    }
}
