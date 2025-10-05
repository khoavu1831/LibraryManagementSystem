using LibraryManagementSystem.Forms;
using LibraryManagementSystem.Views.UserControls.QLNhanVien;
using LibraryManagementSystem.Views.UserControls.QLPhat;
using LibraryManagementSystem.Views.UserControls.QuanLySach;
using LibraryManagementSystem.Views.UserControls.QLMuonTraSach;
using LibraryManagementSystem.Views.UserControls.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.Forms
{
    public partial class MainForm : Form
    {
        private readonly UcTrangChu _ucTrangChu;
        private readonly UcQLSach _ucQLSach;
        private readonly UcQLNhanVien _ucQLNhanVien;
        private readonly UcQLPhat _ucQLPhat;
        private readonly UcQLMuonTraSach _ucQLMuonTraSach;
        public MainForm()
        {
            InitializeComponent();
            _ucTrangChu = new UcTrangChu();
            _ucQLSach = new UcQLSach();
            _ucQLNhanVien = new UcQLNhanVien();
            _ucQLPhat = new UcQLPhat();
            _ucQLMuonTraSach = new UcQLMuonTraSach();
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
        }
        private void btnQLSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLSach);
        }
        private void buttonQLNhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLNhanVien);
        }
        private void buttonQLMuonTraSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLMuonTraSach);
        }
        private void bntPhat_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucQLPhat);

        }
        private void button6_Click(object sender, EventArgs e)
        {

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

    }
}
