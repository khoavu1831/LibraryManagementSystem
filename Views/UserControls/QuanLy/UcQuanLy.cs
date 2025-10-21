using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QuanLy
{
    public partial class UcQuanLy : UserControl
    {
        public UcQuanLy()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaThongTin formSua = new FormSuaThongTin();
            formSua.ShowDialog();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoi = new FormDoiMatKhau();
            formDoi.ShowDialog();
        }
    }
}
