using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Views.UserControls.QLPhat;

namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class UcQLPhat : UserControl
    {
        public UcQLPhat()
        {
            InitializeComponent();
            LoadSubControl(new UcPhat());
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
            LoadSubControl(new UcPhat());
        }

        private void btnTraPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTraPhat());
        }

        private void btnMucPhat_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcMucPhat());
        }
    }
}
