using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class FormSuaTheThanhVien : Form
    {
        private readonly TheThanhVienService _theThanhVienService;
        private readonly LibraryManagementSystem.Entities.TheThanhVien _theThanhVien;

        public FormSuaTheThanhVien(TheThanhVienService theThanhVienService, LibraryManagementSystem.Entities.TheThanhVien theThanhVien)
        {
            InitializeComponent();

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
            comboBoxTrangThai.SelectedValue = _theThanhVien.TrangThai;


        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật dữ liệu từ form
                _theThanhVien.NgayHetHan = dateTimePickerNgayHetHan.Value;
                _theThanhVien.TrangThai = (LibraryManagementSystem.Entities.TheThanhVien.TrangThaiEnum)comboBoxTrangThai.SelectedValue;

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

    }
}
