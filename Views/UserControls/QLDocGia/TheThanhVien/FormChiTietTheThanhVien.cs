using LMS.Helpers;

namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class FormChiTietTheThanhVien : Form
    {
        private readonly Entities.TheThanhVien _theThanhVien;

        public FormChiTietTheThanhVien(Entities.TheThanhVien theThanhVien)
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
            comboBoxTrangThai.DataSource = Enum.GetValues(typeof(Entities.TheThanhVien.TrangThaiEnum))
                .Cast<Entities.TheThanhVien.TrangThaiEnum>()
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
