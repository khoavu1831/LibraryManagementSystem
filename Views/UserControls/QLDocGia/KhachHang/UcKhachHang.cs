namespace LibraryManagementSystem.Views.UserControls.QLDocGia.KhachHang
{
    public partial class UcKhachHang : UserControl
    {
        public UcKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemKhachHang formThemKhachHang = new FormThemKhachHang();
            formThemKhachHang.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaKhachHang formSuaKhachHang = new FormSuaKhachHang();
            formSuaKhachHang.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietKhachHang formChiTietKhachHang = new FormChiTietKhachHang();
            formChiTietKhachHang.Show();
        }
    }
}
