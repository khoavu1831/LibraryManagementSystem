using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormChiTietTacGia : Form
    {
        private readonly int _idTacGia;
        public FormChiTietTacGia(int idTacGia, string tenTacGia, DateTime ngaySinh, string noiSinh, string sdt)
        {
            InitializeComponent();

            _idTacGia = idTacGia;
            textBoxIdTacGia.Text = idTacGia.ToString();
            dateTimePickerNgaySinh.Value = ngaySinh;
            textBoxTenTacGia.Text = tenTacGia;
            textBoxNoiSinh.Text = noiSinh;
            textBoxSDT.Text = sdt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
