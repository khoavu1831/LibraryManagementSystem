﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormChiTietSach : Form
    {
        public FormChiTietSach(string idSach, string tenSach, string theLoai, string tacGia, string nxb, int namXuatBan, string moTa, int soTrang, int soLuongBanSao, decimal giaTien)
        {
            InitializeComponent();

            textBoxIdSach.Text = idSach;
            textBoxTenSach.Text = tenSach;
            textBoxTheLoai.Text = theLoai;
            textBoxTacGia.Text = tacGia;
            textBoxNXB.Text = nxb;
            numericUpDownNamXB.Value = namXuatBan;
            textBoxMoTa.Text = moTa;
            numericUpDownSoTrang.Value = soTrang;
            numericUpDownSoLuongBanSao.Value = soLuongBanSao;
            textBoxGiaSach.Text = giaTien.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
