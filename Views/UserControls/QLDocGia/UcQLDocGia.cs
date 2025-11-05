using LMS.Views.UserControls.QLDocGia.KhachHang;
using LMS.Views.UserControls.QLDocGia.TheThanhVien;

namespace LMS.Views.UserControls.QLDocGia
{
    public partial class UcQLDocGia : UserControl
    {
        private readonly List<string> _permissions;
        public UcQLDocGia(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions;
            LoadSubControl(new UcKhachHang(_permissions));
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcKhachHang(_permissions));
        }

        private void btnTheThanhVien_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTheThanhVien(_permissions));
        }
    }
}
