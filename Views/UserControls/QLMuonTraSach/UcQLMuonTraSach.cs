using LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach;
using LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach
{
    public partial class UcQLMuonTraSach : UserControl
    {
        public UcQLMuonTraSach()
        {
            InitializeComponent();
            LoadSubControl(new UcMuonSach());

        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMuonSach());
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTraSach());
        }
    }
}
