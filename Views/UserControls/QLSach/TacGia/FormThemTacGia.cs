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
    public partial class FormThemTacGia : Form
    {
        private readonly TacGiaService _tacGiaService;
        public FormThemTacGia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var context = new LibraryDbContext();
            var repo = new TacGiaRepository(context);
            _tacGiaService = new TacGiaService(repo);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenTacGia = textBoxTenTacGia.Text.Trim();
            var ngaySinh = dateTimePickerNgaySinh.Value;
            var noiSinh = textBoxNoiSinh.Text.Trim();
            var sdt = textBoxSDT.Text.Trim();

            try
            {
                var tacGia = new TacGia
                {
                    TenTacGia = tenTacGia,
                    NgaySinh = ngaySinh,
                    NoiSinh = noiSinh,
                    SDT = sdt
                };

                _tacGiaService.Save(tacGia);

                MessageBox.Show("Thêm tác giả thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
