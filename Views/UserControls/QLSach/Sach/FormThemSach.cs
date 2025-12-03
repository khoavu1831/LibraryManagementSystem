using System.Text;
using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
using System.Globalization;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormThemSach : Form
    {
        private readonly TheLoaiService _theLoaiService;
        private readonly TacGiaService _tacGiaService;
        private readonly NXBService _nxbService;
        private readonly SachService _sachService;
        public FormThemSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var context = new LibraryDbContext();

            var nxbRepo = new NXBRepository(context);
            var theLoaiRepo = new TheLoaiRepository();
            var tacGiaRepo = new TacGiaRepository(context);
            var sachRepo = new SachRepository(context);

            _theLoaiService = new TheLoaiService(theLoaiRepo);
            _tacGiaService = new TacGiaService(tacGiaRepo);
            _nxbService = new NXBService(nxbRepo);
            _sachService = new SachService(sachRepo);
        }
        private void formThemSach_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadTacGia();
            LoadNXB();
        }
        private void LoadTheLoai()
        {
            var theLoaiList = _theLoaiService.GetAllTheLoai();
            theLoaiList.ForEach(tl => checkedListBoxTheLoai.Items.Add(tl.TenTheloai ?? ""));
        }
        private void LoadTacGia()
        {
            var tacGiaList = _tacGiaService.GetAllTacGia();
            tacGiaList.ForEach(tg => checkedListBoxTacGia.Items.Add(tg.TenTacGia ?? ""));
        }
        private void LoadNXB()
        {
            var nxbList = _nxbService.GetAllNXB();
            comboBoxNXB.DataSource = nxbList;
            comboBoxNXB.DisplayMember = "TenNXB";
            comboBoxNXB.ValueMember = "IdNXB";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu đầu vào
            var errors = new StringBuilder();

            var tenSach = textBoxTenSach.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                errors.AppendLine("- Tên sách không được để trống.");
            }

            var selectedNameTacGias = checkedListBoxTacGia.CheckedItems.Cast<string>().ToList();
            if (!selectedNameTacGias.Any())
            {
                errors.AppendLine("- Vui lòng chọn ít nhất 1 tác giả.");
            }

            var selectedNameTheLoais = checkedListBoxTheLoai.CheckedItems.Cast<string>().ToList();
            if (!selectedNameTheLoais.Any())
            {
                errors.AppendLine("- Vui lòng chọn ít nhất 1 thể loại.");
            }

            if (comboBoxNXB.SelectedItem == null)
            {
                errors.AppendLine("- Vui lòng chọn nhà xuất bản.");
            }

            var namXuatBan = (int)numericUpDownNamXB.Value;
            if (namXuatBan <= 0)
            {
                errors.AppendLine("- Năm xuất bản phải lớn hơn 0.");
            }
            else if (namXuatBan > DateTime.Now.Year)
            {
                errors.AppendLine("- Năm xuất bản không được lớn hơn năm hiện tại.");
            }

            var soTrang = (int)numericUpDownSoTrang.Value;
            if (soTrang <= 0)
            {
                errors.AppendLine("- Số trang phải lớn hơn 0.");
            }

            var moTa = textBoxMoTa.Text.Trim();
            if (string.IsNullOrWhiteSpace(moTa))
            {
                errors.AppendLine("- Mô tả không được để trống.");
            }

            decimal giaTien;
            var giaTienText = textBoxGiaSach.Text.Trim();
            if (string.IsNullOrWhiteSpace(giaTienText))
            {
                errors.AppendLine("- Giá sách không được để trống.");
                giaTien = 0;
            }
            else if (!decimal.TryParse(giaTienText, NumberStyles.Number, CultureInfo.InvariantCulture, out giaTien))
            {
                errors.AppendLine("- Giá sách không hợp lệ. Vui lòng nhập số.");
            }
            else if (giaTien < 0)
            {
                errors.AppendLine("- Giá sách không được nhỏ hơn 0.");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy các tên đã chọn trong danh sách theloai + tacgia
            var selectedNameTheLoaisFinal = checkedListBoxTheLoai.CheckedItems.Cast<string>().ToList();
            var selectedNameTacGiasFinal = checkedListBoxTacGia.CheckedItems.Cast<string>().ToList();

            // Gán dữ liệu cho các thuộc tính của Sách
            var theLoais = _theLoaiService.GetAllTheLoai()
                            .Where(tl => selectedNameTheLoaisFinal.Contains(tl.TenTheloai ?? ""))
                            .ToList();
            var tacGias = _tacGiaService.GetAllTacGia()
                            .Where(tg => selectedNameTacGiasFinal.Contains(tg.TenTacGia ?? ""))
                            .ToList();
            var nxb = (NXB)comboBoxNXB.SelectedItem!;

            try
            {
                var sach = new Sach
                {
                    TenSach = tenSach,
                    TheLoais = theLoais,
                    TacGias = tacGias,
                    NXB = nxb,
                    NamXuatBan = namXuatBan,
                    SoTrang = soTrang,
                    MoTa = moTa,
                    GiaTien = giaTien
                };

                _sachService.AddSach(sach);
                MessageBox.Show("Thêm sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
