using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QuanLySach
{
    public partial class UcQLSach : UserControl
    {
        public UcQLSach()
        {
            InitializeComponent();
            LoadSubControl(new UcSach());
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }
        private void BtnSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcSach());
        }
    }
}
