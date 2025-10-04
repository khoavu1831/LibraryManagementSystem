using System;
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
    public partial class FormThemTheLoai : Form
    {
        private readonly TheLoaiService _theLoaiService;
        public FormThemTheLoai()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var repo = new TheLoaiRepository(context);
            _theLoaiService = new TheLoaiService(repo);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenTheLoai = textBoxTenTheLoai.Text.Trim();

            try
            {
                var theLoai = new TheLoai()
                {
                    TenTheloai = tenTheLoai
                };

                _theLoaiService.Save(theLoai);

                MessageBox.Show("Thêm thể loại thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
