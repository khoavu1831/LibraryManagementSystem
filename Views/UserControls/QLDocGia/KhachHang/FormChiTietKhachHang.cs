namespace LibraryManagementSystem.Views.UserControls.QLDocGia.KhachHang
{
    public partial class FormChiTietKhachHang : Form
    {
        public FormChiTietKhachHang(int idDocGia, string tenDocGia, string diaChi, DateTime ngaySinh, string sdt, string email)
        {
            InitializeComponent();
            // Gán dữ liệu vào các TextBox/DateTimePicker
            textBoxTenKhachHang.Text = tenDocGia;
            textBoxDiaChi.Text = diaChi;
            dateTimePickerDob.Value = ngaySinh;
            textBoxSoDienThoai.Text = sdt;
            textBoxEmail.Text = email;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
