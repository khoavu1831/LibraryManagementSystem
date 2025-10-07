using LibraryManagementSystem.Views.UserControls.QLDocGia.KhachHang;
using LibraryManagementSystem.Views.UserControls.QLDocGia.TheThanhVien;

namespace LibraryManagementSystem.Views.UserControls.QLDocGia
{
    public partial class UcQLDocGia : UserControl
    {
        public UcQLDocGia()
        {
            InitializeComponent();
            LoadSubControl(new UcKhachHang());
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcKhachHang());
        }

        private void btnTheThanhVien_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTheThanhVien());
        }
    }
}
