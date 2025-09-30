using LibraryManagementSystem.Views.UserControls.QLPhat.TraPhat;
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
        public MainForm()
        {
            InitializeComponent();
        }
        private void BtnTrangChu_Click(object sender, EventArgs e)
        {

        }
        private void BtnQLSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControls.QuanLySach.UcQLSach());
        }
        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void bntPhat_Click(object sender, EventArgs e)
        {
            new FormTraPhat().Show(); // mở cửa sổ không chặn

        }
    }
}
