namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcQLNhapSach : UserControl
    {
        private readonly List<string> _permissions;
        public UcQLNhapSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions;
            LoadSubControl(new UcNhapSach(_permissions));
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNhapSach(_permissions));
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNCC(_permissions));
        }
    }
}
