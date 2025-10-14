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
            LoadSubControl(new UcMuonTraSach());

        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMuonTraSach());
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMuonTraSach());
        }
    }
}
