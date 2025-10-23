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
using LMS.Entities;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.UserControls.QLSach
{
    public partial class FormSuaTacGia : Form
    {
        private readonly int _idTacGia;
        public FormSuaTacGia(int idTacGia, string tenTacGia, DateTime ngaySinh, string noiSinh, string sdt)
        {
            InitializeComponent();

            _idTacGia = idTacGia;
            textBoxTenTacGia.Text = tenTacGia;
            dateTimePickerNgaySinh.Value = ngaySinh;
            textBoxNoiSinh.Text = noiSinh;
            textBoxSDT.Text = sdt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenTacGia = textBoxTenTacGia.Text.Trim();
            var ngaySinh = dateTimePickerNgaySinh.Value;
            var noiSinh = textBoxNoiSinh.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new TacGiaRepository(context);
                    var tacGiaService = new TacGiaService(repo);

                    var tacGia = new TacGia
                    {
                        IdTacGia = _idTacGia,
                        TenTacGia = tenTacGia,
                        NgaySinh = ngaySinh,
                        NoiSinh = noiSinh,
                        SDT = sdt
                    };

                    tacGiaService.Save(tacGia);
                }

                MessageBox.Show("Sửa tác giả thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
