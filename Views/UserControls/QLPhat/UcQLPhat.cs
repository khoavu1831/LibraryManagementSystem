using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Views.UserControls.QLPhat;

namespace LMS.Views.UserControls.QLPhat
{
    public partial class UcQLPhat : UserControl
    {
        private readonly List<string> _permissions;
        public UcQLPhat(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions;
            LoadSubControl(new UcPhat(_permissions));
        }

        private void LoadSubControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Clear();
            panelSubContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcPhat(_permissions));
        }

        private void btnTraPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTraPhat(_permissions));
        }

        private void btnMucPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMucPhat(_permissions));
        }
    }
}
