using LibraryManagementSystem.Forms;
using LibraryManagementSystem.Views.UserControls.QLDocGia;
using LibraryManagementSystem.Views.UserControls.QLMuonTraSach;
using LibraryManagementSystem.Views.UserControls.QLNhanVien;
using LibraryManagementSystem.Views.UserControls.QLNhapSach;
using LibraryManagementSystem.Views.UserControls.QLNhapSach.NCC;
using LibraryManagementSystem.Views.UserControls.QLPhat.TraPhat;
using LibraryManagementSystem.Views.UserControls.QLPhat;
using LibraryManagementSystem.Views.UserControls.QLThongKe;
using LibraryManagementSystem.Views.UserControls.QuanLySach;
using LibraryManagementSystem.Views.UserControls.TrangChu;

namespace LibraryManagementSystem.Views.Forms
{
    public partial class MainForm : Form
    {
        private readonly UcTrangChu _ucTrangChu;
        private readonly UcQLSach _ucQLSach;
        private readonly UcQLNhapSach _ucQLNhapSach;
        private readonly UcQLNhanVien _ucQLNhanVien;
        private readonly UcQLPhat _ucQLPhat;
        private readonly UcQLMuonTraSach _ucQLMuonTraSach;
        private readonly UcQLThongKe _ucQLThongKe;
        private readonly UcQLDocGia _ucQLDocGia;
        public MainForm()
        {
            InitializeComponent();
            _ucTrangChu = new UcTrangChu();
            _ucQLSach = new UcQLSach();
            _ucQLNhapSach = new UcQLNhapSach();
            _ucQLNhanVien = new UcQLNhanVien();
            _ucQLPhat = new UcQLPhat();
            _ucQLMuonTraSach = new UcQLMuonTraSach();
            _ucQLThongKe = new UcQLThongKe();
            _ucQLDocGia = new UcQLDocGia();
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
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLThongKe);
            HighlightButton((Button)sender);

        }
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLDocGia);
            HighlightButton((Button)sender);

        }

        private void btnQLNhapSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLNhapSach);

        }
       
       
        


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (LoginForm loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
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
    }
}
