﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormSuaTheLoai : Form
    {
        private readonly int _idTheLoai;
        public FormSuaTheLoai(int idTheLoai, string tenTheLoai)
        {
            InitializeComponent();

            _idTheLoai = idTheLoai;
            textBoxTenTheLoai.Text = tenTheLoai;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenTheLoai = textBoxTenTheLoai.Text.Trim();

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new TheLoaiRepository(context);
                    var theLoaiService = new TheLoaiService(repo);

                    var theLoai = new TheLoai
                    {
                        IdTheLoai = _idTheLoai,
                        TenTheloai = tenTheLoai
                    };

                    theLoaiService.Save(theLoai);
                }

                MessageBox.Show("Sửa thể loại thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
