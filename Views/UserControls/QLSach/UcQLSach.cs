using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcQLSach : UserControl
    {
        private readonly List<string> _permissions;
        public UcQLSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions;
            LoadSubControl(new UcSach(_permissions));
            
        }
        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcSach(_permissions));
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTacGia(_permissions));
        }

        private void btnBanSaoSach_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcBanSaoSach(_permissions));
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNXB(_permissions));
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTheLoai(_permissions));
        }
    }
}
