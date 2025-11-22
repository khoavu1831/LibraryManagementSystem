using LMS.Data;
using LMS.Services;
using Microsoft.EntityFrameworkCore; // For Include
using System.Text.RegularExpressions;
namespace LMS.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class FormSuaVaiTro : Form
    {
        private readonly QuyenService _quyenService;
        private readonly VaiTroService _vaiTroService;
        private readonly int _idVaiTro;
        private List<CheckBox> _quyenCheckboxes = new List<CheckBox>();
        private List<Entities.Quyen> _cachedQuyenList; // Cache Quyens
        private Entities.VaiTro _currentVaiTro; // Lưu vai trò hiện tại để update
        private List<int> _initialCheckedQuyenIds; // Lưu initial checked để so sánh thay đổi
        private LibraryDbContext _sharedContext; // Shared context để tránh multi-context
        public FormSuaVaiTro(int idVaiTro, string tenVaiTro)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            textBoxHVT.Text = tenVaiTro;
            _idVaiTro = idVaiTro;
            SetupLayout(); // Thêm setup layout giống FormThemVaiTro để hiển thị hết
            _sharedContext = new LibraryDbContext(); // Tạo shared context một lần
            _vaiTroService = new VaiTroService(new Repository.VaiTroRepository(_sharedContext));
            _quyenService = new QuyenService(new Repository.QuyenRepository(_sharedContext));
            LoadVaiTroAndQuyen(idVaiTro); // Load dữ liệu vai trò và quyền hiện tại
            btnHuy.Click += BtnHuy_Click; // Thêm event cho nút Hủy
            btnSua.Click += BtnLuu_Click; // Giả sử nút là btnSua, event để lưu thay đổi
            this.FormClosed += (s, e) => _sharedContext?.Dispose(); // Dispose context khi form close
        }
        // Thêm method SetupLayout giống FormThemVaiTro (chỉ setup kích thước/layout để hiển thị hết, không thay đổi màu)
        private void SetupLayout()
        {
            // Giữ kích thước form gốc nhưng tăng nhẹ để fit content (từ Designer 521x549)
            this.ClientSize = new Size(600, 650); // Tăng nhẹ chiều rộng/cao để hiển thị hết checkboxes mà không scroll quá nhiều
            this.MinimumSize = new Size(550, 600); // Tối thiểu để tránh nhỏ quá
            // Header label1 giữ nguyên
            label1.Height = 80; // Giữ nguyên
            // Panel2 Dock.Fill tự động
            panel2.Padding = new Padding(20); // Padding nhẹ để thoáng, không thay đổi màu
            // TableLayoutPanel1 (tên vai trò) - Giữ nguyên, chỉ tăng height nhẹ
            tableLayoutPanel1.Height = 50;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // Buttons tableLayoutPanel2 - Giữ nguyên, đặt dưới
            tableLayoutPanel2.Height = 60;
            tableLayoutPanel2.Location = new Point(0, panel2.Height - 80);
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // TableLayoutPanel3 (phần quyền) - Tăng size để hiển thị hết, thêm scroll nếu cần
            tableLayoutPanel3.Location = new Point(0, 70);
            tableLayoutPanel3.Size = new Size(panel2.Width - 40, panel2.Height - 180); // Chiếm hầu hết, trừ input/buttons
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Responsive
            tableLayoutPanel3.AutoScroll = true; // Scroll nếu nhiều quyền, đảm bảo hiển thị hết
        }
        // Load vai trò và quyền từ DB (sử dụng shared context để load navigation property Quyens)
        private void LoadVaiTroAndQuyen(int idVaiTro)
        {
            try
            {
                _currentVaiTro = _sharedContext.VaiTros
                    .Include(v => v.Quyens) // Load Quyens để có checkedQuyenIds
                    .FirstOrDefault(v => v.IdVaiTro == idVaiTro);
                if (_currentVaiTro == null)
                {
                    MessageBox.Show("Không tìm thấy vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                // Cache Quyens từ shared context
                _cachedQuyenList = _quyenService.GetAllQuyen();
                // Render checkboxes với checked từ _currentVaiTro.Quyens (dựa trên DB)
                var checkedQuyenIds = _currentVaiTro.Quyens?.Select(q => q.IdQuyen).ToList() ?? new List<int>();
                _initialCheckedQuyenIds = new List<int>(checkedQuyenIds); // Lưu initial để so sánh sau
                RenderQuyenCheckboxes(checkedQuyenIds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Render checkboxes (giống FormThemVaiTro, nhưng enabled=true cho edit, và checked từ checkedQuyenIds)
        private void RenderQuyenCheckboxes(List<int>? checkedQuyenIds = null)
        {
            // Sử dụng cache để load nhanh
            var quyenList = _cachedQuyenList;
            var modules = quyenList.GroupBy(q => q.TenQuyen).OrderByDescending(g => g.Key); // Group by TenQuyen, reverse order
            // Clear và setup lại tableLayoutPanel3 (giữ màu gốc)
            tableLayoutPanel3.Controls.Clear();
            tableLayoutPanel3.ColumnStyles.Clear();
            tableLayoutPanel3.RowStyles.Clear();
            tableLayoutPanel3.ColumnCount = 0;
            tableLayoutPanel3.RowCount = 0;
            _quyenCheckboxes.Clear();
            if (!modules.Any())
            {
                var lblNoData = new Label { Text = "Không có quyền nào để hiển thị.", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
                tableLayoutPanel3.Controls.Add(lblNoData, 0, 0);
                tableLayoutPanel3.ColumnCount = 1;
                tableLayoutPanel3.RowCount = 1;
                return;
            }
            int currentRow = 0;
            int maxCols = 4; // Fixed 4 cột cho Thêm, Sửa, Xóa, Chi tiết
            // Thêm row 0 cho header: Col 0 = "Tên chức năng", Col 1-4 = "Thêm", "Sửa", "Xóa", "Chi tiết"
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F)); // Height cho header ngang
            // Setup columns: 5 cột (0: Tên, 1-4: Quyền)
            tableLayoutPanel3.ColumnCount = maxCols + 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); // Cột tên chức năng
            for (int i = 0; i < maxCols; i++)
            {
                tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F / maxCols)); // Cột quyền
            }
            // Kẻ đường ngăn cách cho table (dễ nhìn)
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Border giữa cells
            tableLayoutPanel3.BackColor = Color.White; // Nền trắng để border nổi bật
            // Header row 0
            // Col 0: "Tên chức năng"
            var lblTenChucNang = new Label
            {
                Text = "Tên chức năng",
                AutoSize = false,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold), // Font nhỏ
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(8)
            };
            tableLayoutPanel3.Controls.Add(lblTenChucNang, 0, 0);
            // Col 1-4: Labels "Thêm", "Sửa", "Xóa", "Chi tiết"
            string[] quyenNames = { "Thêm", "Sửa", "Xóa", "Chi tiết" };
            for (int i = 0; i < maxCols; i++)
            {
                var lblQuyen = new Label
                {
                    Text = quyenNames[i],
                    AutoSize = false,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold), // Font nhỏ
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(8)
                };
                tableLayoutPanel3.Controls.Add(lblQuyen, i + 1, 0);
            }
            currentRow = 1; // Bắt đầu module từ row 1
            foreach (var module in modules)
            {
                // Thêm row cho module name và checkboxes cùng row (để chỉ 1 dòng cho module + 4 checkbox)
                tableLayoutPanel3.RowCount++;
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // Height row kết hợp module + checkboxes
                // Col 0: Tên module (từ TenQuyen, reverse order)
                var lblModule = new Label
                {
                    Text = module.Key, // TenQuyen (tên chức năng từ DB)
                    AutoSize = false,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold), // Font nhỏ
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft, // Align left
                    Margin = new Padding(8)
                };
                tableLayoutPanel3.Controls.Add(lblModule, 0, currentRow);
                tableLayoutPanel3.SetColumnSpan(lblModule, 1); // Chỉ col 0
                // Lấy đúng 4 quyền cho module này dựa trên MaQuyen (nếu có)
                var themQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("ADD"));
                var suaQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("EDIT"));
                var xoaQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("DELETE"));
                var chietQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("VIEW"));
                // Col 1: Checkbox Thêm (cùng row với module name)
                var cbThem = new CheckBox
                {
                    Tag = themQuyen?.IdQuyen ?? 0,
                    Checked = checkedQuyenIds != null && checkedQuyenIds.Contains(themQuyen?.IdQuyen ?? 0), // Tick nếu có trong vaiTro.Quyens (từ DB)
                    Enabled = true, // Enabled cho edit
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular), // Font nhỏ
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "", // Không text
                    TextAlign = ContentAlignment.MiddleCenter, // Checkbox ở giữa
                    CheckAlign = ContentAlignment.MiddleCenter // Check box ở giữa
                };
                tableLayoutPanel3.Controls.Add(cbThem, 1, currentRow);
                _quyenCheckboxes.Add(cbThem);
                // Col 2: Checkbox Sửa
                var cbSua = new CheckBox
                {
                    Tag = suaQuyen?.IdQuyen ?? 0,
                    Checked = checkedQuyenIds != null && checkedQuyenIds.Contains(suaQuyen?.IdQuyen ?? 0), // Tick nếu có trong vaiTro.Quyens (từ DB)
                    Enabled = true, // Enabled cho edit
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,
                    CheckAlign = ContentAlignment.MiddleCenter
                };
                tableLayoutPanel3.Controls.Add(cbSua, 2, currentRow);
                _quyenCheckboxes.Add(cbSua);
                // Col 3: Checkbox Xóa
                var cbXoa = new CheckBox
                {
                    Tag = xoaQuyen?.IdQuyen ?? 0,
                    Checked = checkedQuyenIds != null && checkedQuyenIds.Contains(xoaQuyen?.IdQuyen ?? 0), // Tick nếu có trong vaiTro.Quyens (từ DB)
                    Enabled = true, // Enabled cho edit
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,
                    CheckAlign = ContentAlignment.MiddleCenter
                };
                tableLayoutPanel3.Controls.Add(cbXoa, 3, currentRow);
                _quyenCheckboxes.Add(cbXoa);
                // Col 4: Checkbox Chi tiết
                var cbChiet = new CheckBox
                {
                    Tag = chietQuyen?.IdQuyen ?? 0,
                    Checked = checkedQuyenIds != null && checkedQuyenIds.Contains(chietQuyen?.IdQuyen ?? 0), // Tick nếu có trong vaiTro.Quyens (từ DB)
                    Enabled = true, // Enabled cho edit
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,
                    CheckAlign = ContentAlignment.MiddleCenter
                };
                tableLayoutPanel3.Controls.Add(cbChiet, 4, currentRow);
                _quyenCheckboxes.Add(cbChiet);
                currentRow++; // Chỉ tăng 1 cho row kết hợp, không spacer riêng
            }
            // Ẩn label cũ
            label3.Visible = false;
        }
        // Event cho nút Lưu (giả sử nút là btnSua, nhưng dùng để lưu thay đổi)
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string tenVaiTroMoi = textBoxHVT.Text.Trim();
            if (string.IsNullOrEmpty(tenVaiTroMoi))
            {
                MessageBox.Show("Tên vai trò không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHVT.Focus();
                return;
            }
            // Validation thủ công (copy từ service)
            if (!Regex.IsMatch(tenVaiTroMoi, @"^[\p{L}\s]{1,20}$"))
            {
                MessageBox.Show("Tên vai trò chỉ được chứa chữ cái và tối đa 20 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHVT.Focus();
                return;
            }
            // Kiểm tra thay đổi đơn giản (tên hoặc quyền)
            bool hasNameChange = tenVaiTroMoi != _currentVaiTro.TenVaiTro;
            bool hasQuyenChange = _quyenCheckboxes.Any(cb => cb.Checked != _initialCheckedQuyenIds.Contains((int)cb.Tag)); // So sánh với initial checked
            if (!hasNameChange && !hasQuyenChange)
            {
                MessageBox.Show("Không có thay đổi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            try
            {
                // Sử dụng shared context để update (tránh multi-context)
                // Reload entity trong shared context để tracked
                _sharedContext.Entry(_currentVaiTro).State = EntityState.Detached; // Detach nếu cần
                var vaiTroToUpdate = _sharedContext.VaiTros
                    .Include(v => v.Quyens)
                    .Single(v => v.IdVaiTro == _idVaiTro);
                // Update tên
                vaiTroToUpdate.TenVaiTro = tenVaiTroMoi;
                // Clear quyền cũ
                vaiTroToUpdate.Quyens.Clear();
                // Gán quyền mới từ checkboxes
                var selectedQuyenIds = _quyenCheckboxes
                    .Where(cb => cb.Checked && (int)cb.Tag > 0) // Chỉ lấy checked và Id hợp lệ
                    .Select(cb => (int)cb.Tag)
                    .ToList();
                foreach (var idQuyen in selectedQuyenIds)
                {
                    // Load Quyen in shared context (will be tracked)
                    var quyen = _sharedContext.Quyens.Find(idQuyen);
                    if (quyen != null)
                    {
                        // Add to collection (EF inserts junction)
                        vaiTroToUpdate.Quyens.Add(quyen);
                    }
                }
                // Save all changes (name + junctions)
                _sharedContext.SaveChanges();
                MessageBox.Show("Cập nhật vai trò và quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}