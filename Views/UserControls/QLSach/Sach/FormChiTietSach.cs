using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormChiTietSach : Form
    {
        public FormChiTietSach(string idSach, string tenSach, string theLoai, string tacGia, string nxb, int namXuatBan, string moTa, int soTrang, int soLuongBanSao, decimal giaTien)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxIdSach.Text = idSach;
            textBoxTenSach.Text = tenSach;
            textBoxTheLoai.Text = theLoai;
            textBoxTacGia.Text = tacGia;
            textBoxNXB.Text = nxb;
            numericUpDownNamXB.Value = namXuatBan;
            textBoxMoTa.Text = moTa;
            numericUpDownSoTrang.Value = soTrang;
            numericUpDownSoLuongBanSao.Value = soLuongBanSao;
            // Hiển thị giá tiền có định dạng phân cách hàng nghìn, giống màn sửa sách
            textBoxGiaSach.Text = giaTien.ToString("N0");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
