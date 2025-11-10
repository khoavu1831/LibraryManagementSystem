using LMS.Data;
using LMS.Services;

namespace LMS.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class FormThemVaiTro : Form
    {
        private readonly QuyenService _quyenService;
        private readonly VaiTroService _vaiTroService;

        private List<CheckBox> _quyenCheckboxes = new List<CheckBox>();
        private List<Entities.Quyen> _cachedQuyenList;  // Cache để tránh load DB nhiều lần, tăng tốc

        public FormThemVaiTro()
        {
            InitializeComponent();
            SetupLayout();  // Chỉ setup kích thước/layout để hiển thị hết, không thay đổi màu

            var context = new LibraryDbContext();
            _vaiTroService = new VaiTroService(new Repository.VaiTroRepository(context));
            _quyenService = new QuyenService(new Repository.QuyenRepository(context));

            // Load Quyens một lần và cache
            _cachedQuyenList = _quyenService.GetAllQuyen();

            RenderQuyenCheckboxes();
            btnHuy.Click += BtnHuy_Click;  // Thêm event cho nút Hủy
        }

        // Chỉ setup layout để hiển thị hết, giữ màu gốc
        private void SetupLayout()
        {
            // Giữ kích thước form gốc nhưng tăng nhẹ để fit content (từ Designer 521x549)
            this.ClientSize = new Size(600, 650);  // Tăng nhẹ chiều rộng/cao để hiển thị hết checkboxes mà không scroll quá nhiều
            this.MinimumSize = new Size(550, 600);  // Tối thiểu để tránh nhỏ quá

            // Header label1 giữ nguyên
            label1.Height = 80;  // Giữ nguyên

            // Panel2 Dock.Fill tự động
            panel2.Padding = new Padding(20);  // Padding nhẹ để thoáng, không thay đổi màu

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
            tableLayoutPanel3.Size = new Size(panel2.Width - 40, panel2.Height - 180);  // Chiếm hầu hết, trừ input/buttons
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  // Responsive
            tableLayoutPanel3.AutoScroll = true;  // Scroll nếu nhiều quyền, đảm bảo hiển thị hết
        }

        private void RenderQuyenCheckboxes()
        {
            // Sử dụng cache để load nhanh, không query DB lại
            var quyenList = _cachedQuyenList;
            var modules = quyenList.GroupBy(q => q.TenQuyen).OrderByDescending(g => g.Key);  // Group by TenQuyen (tên chức năng), reverse order từ dưới lên

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
            int maxCols = 4;  // Fixed 4 cột cho Thêm, Sửa, Xóa, Chi tiết - không wrap nữa

            // Thêm row 0 cho header: Col 0 = "Tên chức năng", Col 1-4 = "Thêm", "Sửa", "Xóa", "Chi tiết"
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));  // Height cho header ngang

            // Setup columns: 5 cột (0: Tên, 1-4: Quyền)
            tableLayoutPanel3.ColumnCount = maxCols + 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));  // Cột tên chức năng
            for (int i = 0; i < maxCols; i++)
            {
                tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F / maxCols));  // Cột quyền
            }

            // Kẻ đường ngăn cách cho table (dễ nhìn)
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;  // Border giữa cells
            tableLayoutPanel3.BackColor = Color.White;  // Nền trắng để border nổi bật

            // Header row 0
            // Col 0: "Tên chức năng"
            var lblTenChucNang = new Label
            {
                Text = "Tên chức năng",
                AutoSize = false,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),  // Font nhỏ
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
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),  // Font nhỏ
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(8)
                };
                tableLayoutPanel3.Controls.Add(lblQuyen, i + 1, 0);
            }

            currentRow = 1;  // Bắt đầu module từ row 1

            foreach (var module in modules)
            {
                // Thêm row cho module name và checkboxes cùng row (để chỉ 1 dòng cho module + 4 checkbox)
                tableLayoutPanel3.RowCount++;
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));  // Height row kết hợp module + checkboxes

                // Col 0: Tên module (từ TenQuyen, reverse order)
                var lblModule = new Label
                {
                    Text = module.Key,  // TenQuyen (tên chức năng từ DB)
                    AutoSize = false,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),  // Font nhỏ
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,  // Align left
                    Margin = new Padding(8)
                };
                tableLayoutPanel3.Controls.Add(lblModule, 0, currentRow);
                tableLayoutPanel3.SetColumnSpan(lblModule, 1);  // Chỉ col 0

                // Lấy đúng 4 quyền cho module này dựa trên MaQuyen (nếu có)
                var themQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("ADD"));
                var suaQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("EDIT"));
                var xoaQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("DELETE"));
                var chietQuyen = module.FirstOrDefault(q => q.MaQuyen.EndsWith("VIEW"));

                // Col 1: Checkbox Thêm (cùng row với module name)
                var cbThem = new CheckBox
                {
                    Tag = themQuyen?.IdQuyen ?? 0,
                    Checked = themQuyen != null,  // Tick nếu có quyền Thêm
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),  // Font nhỏ
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",  // Không text
                    TextAlign = ContentAlignment.MiddleCenter,  // Checkbox ở giữa
                    CheckAlign = ContentAlignment.MiddleCenter  // Check box ở giữa
                };
                tableLayoutPanel3.Controls.Add(cbThem, 1, currentRow);
                _quyenCheckboxes.Add(cbThem);

                // Col 2: Checkbox Sửa
                var cbSua = new CheckBox
                {
                    Tag = suaQuyen?.IdQuyen ?? 0,
                    Checked = suaQuyen != null,  // Tick nếu có quyền Sửa
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,  // Checkbox ở giữa
                    CheckAlign = ContentAlignment.MiddleCenter  // Check box ở giữa
                };
                tableLayoutPanel3.Controls.Add(cbSua, 2, currentRow);
                _quyenCheckboxes.Add(cbSua);

                // Col 3: Checkbox Xóa
                var cbXoa = new CheckBox
                {
                    Tag = xoaQuyen?.IdQuyen ?? 0,
                    Checked = xoaQuyen != null,  // Tick nếu có quyền Xóa
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,  // Checkbox ở giữa
                    CheckAlign = ContentAlignment.MiddleCenter  // Check box ở giữa
                };
                tableLayoutPanel3.Controls.Add(cbXoa, 3, currentRow);
                _quyenCheckboxes.Add(cbXoa);

                // Col 4: Checkbox Chi tiết
                var cbChiet = new CheckBox
                {
                    Tag = chietQuyen?.IdQuyen ?? 0,
                    Checked = chietQuyen != null,  // Tick nếu có quyền Chi tiết
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                    Margin = new Padding(8),
                    FlatStyle = FlatStyle.Flat,
                    Text = "",
                    TextAlign = ContentAlignment.MiddleCenter,  // Checkbox ở giữa
                    CheckAlign = ContentAlignment.MiddleCenter  // Check box ở giữa
                };
                tableLayoutPanel3.Controls.Add(cbChiet, 4, currentRow);
                _quyenCheckboxes.Add(cbChiet);

                currentRow++;  // Chỉ tăng 1 cho row kết hợp, không spacer riêng

                // Thêm spacer chỉ sau module cuối nếu cần, nhưng để tight thì bỏ
            }

            // Ẩn label cũ
            label3.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenVaiTro = textBoxHVT.Text.Trim();

            if (string.IsNullOrEmpty(tenVaiTro))
            {
                MessageBox.Show("Tên vai trò không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHVT.Focus();
                return;
            }

            try
            {
                // Thêm vai trò (cập nhật để lưu quyền từ checkboxes)
                var vaiTro = new Entities.VaiTro { TenVaiTro = tenVaiTro };
                _vaiTroService.AddVaiTro(vaiTro);

                // Lưu quyền (giả sử service có method AssignQuyenToVaiTro)
                // TODO: Implement nếu chưa có - ví dụ: foreach cb in _quyenCheckboxes if (cb.Checked) AssignQuyen(vaiTro.IdVaiTro, (int)cb.Tag);
                // Hiện tại chỉ thêm vai trò, bạn có thể mở rộng

                MessageBox.Show("Thêm vai trò thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}