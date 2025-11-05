namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    public partial class UcKhachHang : UserControl
    {
        public UcKhachHang(List<string> permissions)
        {
            InitializeComponent();
            var canAdd = permissions.Contains("KHACHHANG_ADD");
            var canEdit = permissions.Contains("KHACHHANG_EDIT");
            var canDelete = permissions.Contains("KHACHHANG_DELETE");
            var canViewDetails = permissions.Contains("KHACHHANG_VIEW");
            var canExport = permissions.Contains("KHACHHANG_EXPORT");
            btnThem.Enabled = canAdd;
            btnSua.Enabled = canEdit;
            btnXoa.Enabled = canDelete;
            btnChiTiet.Enabled = canViewDetails;
            btnExcel.Enabled = canExport;
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
