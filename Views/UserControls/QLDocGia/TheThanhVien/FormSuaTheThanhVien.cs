using LMS.Helpers;
using LMS.Views.LMS.Services.Services;

namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class FormSuaTheThanhVien : Form
    {
        private readonly TheThanhVienService _theThanhVienService;
        private readonly Entities.TheThanhVien _theThanhVien;

        public FormSuaTheThanhVien(TheThanhVienService theThanhVienService, Entities.TheThanhVien theThanhVien)
        {
            InitializeComponent();
            dateTimePickerNgayCap.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayCap.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayHetHan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.StartPosition = FormStartPosition.CenterParent;

            _theThanhVienService = theThanhVienService ?? throw new ArgumentNullException(nameof(theThanhVienService));
            _theThanhVien = theThanhVien ?? throw new ArgumentNullException(nameof(theThanhVien));

            LoadData();
        }

        private void LoadData()
        {
            // Hiển thị thông tin hiện tại
            textBoxIDTheThanhVien.Text = _theThanhVien.IdTheThanhVien.ToString();
            textBoxIDKhachHang.Text = _theThanhVien.IdDocGia.ToString();
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
            comboBoxTrangThai.SelectedValue = _theThanhVien.TrangThai;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật dữ liệu từ form
                _theThanhVien.NgayHetHan = dateTimePickerNgayHetHan.Value;
                _theThanhVien.TrangThai = (Entities.TheThanhVien.TrangThaiEnum)comboBoxTrangThai.SelectedValue;

                // Lưu thay đổi
                _theThanhVienService.UpdateTheThanhVien(_theThanhVien);

                MessageBox.Show("Cập nhật thẻ thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
