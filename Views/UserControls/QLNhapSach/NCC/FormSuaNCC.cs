using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
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

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class FormSuaNCC : Form
    {
        private readonly int _idNCC;
        public FormSuaNCC(int idNCC, string tenNCC ,string diaChi, string sdt)
        {
            InitializeComponent();

            _idNCC = idNCC;
            textBoxTenNCC.Text = tenNCC;
            textBoxDiaChi.Text = diaChi;
            textBoxSDT.Text = sdt;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenNCC = textBoxTenNCC.Text.Trim();
            var diaChi = textBoxDiaChi.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new NCCRepository(context);
                    var nccService = new NCCService(repo);

                    var ncc = new NCC
                    {
                        IdNCC = _idNCC,
                        TenNCC = tenNCC,
                        DiaChi = diaChi,
                        SDT = sdt
                    };

                    nccService.Save(ncc);
                }

                MessageBox.Show("Sửa nhà cung cấp thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
