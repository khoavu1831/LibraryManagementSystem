using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLMuonTraSach
{
    public partial class UcQLMuonTraSach : UserControl
    {
        private readonly List<string> _permissions;
        public UcQLMuonTraSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions;
            LoadSubControl(new UcMuonTraSach(_permissions));

        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMuonTraSach(_permissions));
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMuonTraSach(_permissions));
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSau_Click(object sender, EventArgs e)
        {

        }

        private void labelTrang_Click(object sender, EventArgs e)
        {

        }
    }
}
