using LMS.Services;

namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    public partial class FormSuaKhachHang : Form
    {
        private readonly DocGiaService _docGiaService;
        private readonly int _idDocGia;
        public FormSuaKhachHang(DocGiaService docGiaService, int idDocGia, string tenDocGia, string diaChi, DateTime ngaySinh, string sdt, string email)
        {
            InitializeComponent();
            _docGiaService = docGiaService;
            _idDocGia = idDocGia;

            // Gán dữ liệu vào các control
            textBoxTenKhachHang.Text = tenDocGia;
            textBoxDiaChi.Text = diaChi;
            dateTimePickerDob.Value = ngaySinh;
            textBoxSoDienThoai.Text = sdt;
            textBoxEmail.Text = email;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var existing = _docGiaService.GetDocGiaById(_idDocGia);
                // Lấy dữ liệu từ form
                existing.TenDocGia = textBoxTenKhachHang.Text.Trim();
                existing.DiaChi = textBoxDiaChi.Text.Trim();
                existing.NgaySinh = dateTimePickerDob.Value;
                existing.SDT = textBoxSoDienThoai.Text.Trim();
                existing.Email = textBoxEmail.Text.Trim();

                // Cập nhật dữ liệu
                _docGiaService.UpdateDocGia(existing);

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
