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
using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormThemTheLoai : Form
    {
        private readonly TheLoaiService _theLoaiService;
        public FormThemTheLoai()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var repo = new TheLoaiRepository();
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
                DialogResult = DialogResult.OK;
                Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
