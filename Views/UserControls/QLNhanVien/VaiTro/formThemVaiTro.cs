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
    public partial class FormThemVaiTro : Form
    {
        private readonly Services.VaiTroService _vaiTroService;
        public FormThemVaiTro()
        {
            InitializeComponent();

            var context = new LibraryDbContext();
            var vaiTroRepo = new Repository.VaiTroRepository(context);
            _vaiTroService = new Services.VaiTroService(vaiTroRepo);
        }


        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string tenVaiTro = textBoxHVT.Text.Trim();
            if(_vaiTroService.AddVaiTro(new Entities.VaiTro { TenVaiTro = tenVaiTro }))
            {
                this.Close();
                MessageBox.Show("Thêm vai trò thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
