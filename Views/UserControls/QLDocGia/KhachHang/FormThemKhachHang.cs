using LMS.Services;

namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    public partial class FormThemKhachHang : Form
    {
        private readonly DocGiaService _docGiaService;

        public FormThemKhachHang(DocGiaService docGiaService)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            _docGiaService = docGiaService;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy dữ liệu từ form
                var docGia = new Entities.DocGia
                {
                    TenDocGia = textBoxTenKhachHang.Text.Trim(),
                    DiaChi = textBoxDiaChi.Text.Trim(),
                    NgaySinh = dateTimePickerDob.Value,
                    SDT = textBoxSoDienThoai.Text.Trim(),
                    Email = textBoxEmail.Text.Trim()
                };

                // 2️⃣ Gọi service để thêm
                _docGiaService.AddDocGia(docGia);

                // 3️⃣ Thông báo thành công
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4️⃣ Đóng form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
