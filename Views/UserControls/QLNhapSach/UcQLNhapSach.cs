namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcQLNhapSach : UserControl
    {
        public UcQLNhapSach()
        {
            InitializeComponent();
            LoadSubControl(new UcNhapSach());
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNhapSach());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNCC());
        }
    }
}
