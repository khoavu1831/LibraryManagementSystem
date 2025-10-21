using LMS.Views.UserControls.QLNhanVien.NhanVien;
using LMS.Views.UserControls.QLNhanVien.Quyen;
using LMS.Views.UserControls.QLNhanVien.TaiKhoan;
using LMS.Views.UserControls.QLNhanVien.VaiTro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhanVien
{
    public partial class UcQLNhanVien : UserControl
    {
        public UcQLNhanVien()
        {
            InitializeComponent();
            LoadSubControl(new UcNhanVien());
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcNhanVien());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcTaiKhoan());
        }

        private void btnVaiTro_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcVaiTro());
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            LoadSubControl(new UcQuyen());
        }
    }
}
