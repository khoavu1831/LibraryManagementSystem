using LibraryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLNhanVien.VaiTro
{
    public partial class FormSuaVaiTro : Form
    {
        private readonly int _idVaiTro;
        public FormSuaVaiTro(int idVaiTro, string tenVaiTro)
        {
            InitializeComponent();
            textBoxHVT.Text = tenVaiTro;
            _idVaiTro = idVaiTro;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenVaiTro = textBoxHVT.Text.Trim();
            using (var context = new LibraryDbContext())
            {
                var repo = new Repository.VaiTroRepository(context);
                var vaiTroService = new Services.VaiTroService(repo);
                if(vaiTroService.UpdateVaiTro(new Entities.VaiTro { IdVaiTro = _idVaiTro, TenVaiTro = tenVaiTro }) == true)
                {
                    this.Close();
                    MessageBox.Show("Sửa vai trò thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
