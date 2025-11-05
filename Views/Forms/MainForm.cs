using LMS.Forms;
using LMS.Views.UserControls.QLDocGia;
using LMS.Views.UserControls.QLMuonTraSach;
using LMS.Views.UserControls.QLNhanVien;
using LMS.Views.UserControls.QLPhat;
using LMS.Views.UserControls.QLThongKe;
using LMS.Views.UserControls.QLSach;
using LMS.Views.UserControls.TrangChu;
using LMS.Views.UserControls.QLNhapSach;
using LMS.Views.UserControls.QuanLy;


namespace LMS.Views.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<string> _userPermissions;

        private readonly UcTrangChu _ucTrangChu;
        private readonly UcQLSach _ucQLSach;
        private readonly UcQLNhapSach _ucQLNhapSach;
        private readonly UcQLNhanVien _ucQLNhanVien;
        private readonly UcQLPhat _ucQLPhat;
        private readonly UcQLMuonTraSach _ucQLMuonTraSach;
        private readonly UcQLThongKe _ucQLThongKe;
        private readonly UcQLDocGia _ucQLDocGia;
        private readonly UcQuanLy _ucQuanLy;
        public MainForm(List<string> userPermissions)
        {
            InitializeComponent();
            _userPermissions = userPermissions;

            _ucTrangChu = new UcTrangChu();
            _ucQLSach = new UcQLSach(_userPermissions);
            _ucQLNhapSach = new UcQLNhapSach(_userPermissions);
            _ucQLNhanVien = new UcQLNhanVien(_userPermissions);
            _ucQLPhat = new UcQLPhat(_userPermissions);
            _ucQLMuonTraSach = new UcQLMuonTraSach(_userPermissions);
            _ucQLThongKe = new UcQLThongKe();
            _ucQLDocGia = new UcQLDocGia(_userPermissions);
            _ucQuanLy = new UcQuanLy();
            LoadUserControl(_ucTrangChu);
        }
        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucTrangChu);
            HighlightButton((Button)sender);
        }
        private void btnQLSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLSach);
            HighlightButton((Button)sender);

        }
        private void buttonQLNhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLNhanVien);
            HighlightButton((Button)sender);

        }
        private void buttonQLMuonTraSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLMuonTraSach);
            HighlightButton((Button)sender);

        }
        private void bntPhat_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLPhat);
            HighlightButton((Button)sender);


        }
        private void btnQLNhapSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLNhapSach);
            HighlightButton((Button)sender);
        }
        private void btnQLThongKe_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLThongKe);
            HighlightButton((Button)sender);
        }
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLDocGia);
            HighlightButton((Button)sender);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();

            using (LoginForm loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Show();
                }
                else
                {
                    Close();
                }
            }
        }

        private void ResetMenuColors()
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void HighlightButton(Button btn)
        {
            ResetMenuColors();
            btn.BackColor = Color.LightSeaGreen;
            btn.ForeColor = Color.White;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {

            LoadUserControl(_ucQuanLy);
           
        }
    }
}
