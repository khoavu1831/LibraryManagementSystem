namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    public partial class UcTheThanhVien : UserControl
    {
        public UcTheThanhVien()
        {
            InitializeComponent();
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
