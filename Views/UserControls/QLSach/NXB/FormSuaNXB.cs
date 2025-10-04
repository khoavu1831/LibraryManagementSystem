using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
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

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormSuaNXB : Form
    {
        private readonly int _idNXB;
        public FormSuaNXB(int idNXB, string tenNXB ,string diaChi, string sdt)
        {
            InitializeComponent();

            _idNXB = idNXB;
            textBoxTenNXB.Text = tenNXB;
            textBoxDiaChi.Text = diaChi;
            textBoxSDT.Text = sdt;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenNXB = textBoxTenNXB.Text.Trim();
            var diaChi = textBoxDiaChi.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NXBRepository(context);
                    var _nxbService = new NXBService(repo);

                    var nxb = new NXB
                    {
                        IdNXB = _idNXB,
                        TenNXB = tenNXB,
                        DiaChi = diaChi,
                        SDT = sdt
                    };

                    _nxbService.Save(nxb);
                }

                MessageBox.Show("Sửa nhà xuất bản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
