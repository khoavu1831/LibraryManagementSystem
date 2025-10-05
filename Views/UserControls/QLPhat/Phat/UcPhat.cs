using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLPhat;
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

namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class UcPhat : UserControl
    {
        //private readonly PhatService _phatService;
        public UcPhat()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuPhat = new FormThemPhieuPhat())
            {
                formThemPhieuPhat.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietPhieuPhat = new FormChiTietPhieuPhat())
            {
                formChiTietPhieuPhat.ShowDialog(this);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
