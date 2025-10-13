using LibraryManagementSystem.Helpers;

namespace LibraryManagementSystem.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class FormChiTietTheThanhVien : Form
    {
        private readonly LibraryManagementSystem.Entities.TheThanhVien _theThanhVien;

        public FormChiTietTheThanhVien(LibraryManagementSystem.Entities.TheThanhVien theThanhVien)
        {
            InitializeComponent();
            _theThanhVien = theThanhVien ?? throw new ArgumentNullException(nameof(theThanhVien));

            LoadData();
        }

        private void LoadData()
        {
            // Hiển thị thông tin thẻ
            textBoxIDKhachHang.Text = _theThanhVien.IdTheThanhVien.ToString();
            textBoxIDTheThanhVien.Text = _theThanhVien.IdDocGia.ToString();
            dateTimePickerNgayHetHan.Value = _theThanhVien.NgayHetHan;

            // Bind ComboBox trạng thái từ enum
            comboBoxTrangThai.DataSource = Enum.GetValues(typeof(LibraryManagementSystem.Entities.TheThanhVien.TrangThaiEnum))
                .Cast<LibraryManagementSystem.Entities.TheThanhVien.TrangThaiEnum>()
                .Select(e => new
                {
                    Value = e,
                    Display = e.GetDisplayName()
                })
                .ToList();

            comboBoxTrangThai.ValueMember = "Value";
            comboBoxTrangThai.DisplayMember = "Display";

            // Chọn trạng thái hiện tại
            comboBoxTrangThai.SelectedValue = _theThanhVien.TrangThai;


        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
