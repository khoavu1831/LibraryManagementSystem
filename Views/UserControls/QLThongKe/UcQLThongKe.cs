using LibraryManagementSystem.Views.UserControls.QLThongKe.Chung;
using LibraryManagementSystem.Views.UserControls.QLThongKe.PhieuPhat;
using LibraryManagementSystem.Views.UserControls.QLThongKe.SachMuon;
using LibraryManagementSystem.Views.UserControls.QLThongKe.SachNhap;
using LibraryManagementSystem.Views.UserControls.QLThongKe.ThanhVien;



namespace LibraryManagementSystem.Views.UserControls.QLThongKe
{
    public partial class UcQLThongKe : UserControl
    {
        public UcQLThongKe()
        {
            InitializeComponent();
            LoadSubControl(new UcChung());
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcThanhVien());
        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcPhieuPhat());
        }

        private void btnSachNhap_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcSachNhap());
        }

        private void btnSachMuon_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcSachMuon());
        }

        private void btnChung_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcChung());
        }
    }
}
