namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class UcTheThanhVien : UserControl
    {
        public UcTheThanhVien(List<string> permissions)
        {
            InitializeComponent();
            var canEdit = permissions.Contains("THETHANHVIEN_EDIT");
            var canDelete = permissions.Contains("THETHANHVIEN_DELETE");
            var canViewDetails = permissions.Contains("THETHANHVIEN_VIEW");
            btnSua.Enabled = canEdit;
            btnChiTiet.Enabled = canViewDetails;
            btnXoa.Enabled = canDelete;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaTheThanhVien formSuaTheThanhVien = new FormSuaTheThanhVien();
            formSuaTheThanhVien.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietTheThanhVien formChiTietTheThanhVien = new FormChiTietTheThanhVien();
            formChiTietTheThanhVien.Show();
        }
    }
}
