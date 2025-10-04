using LibraryManagementSystem.Data;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class UcNXB : UserControl
    {
        private readonly NXBService _nxbService;
        public UcNXB()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var nxbRepository = new NXBRepository(context);
            _nxbService = new NXBService(nxbRepository);
            LoadData();
        }

        private void LoadData()
        {
            var data = _nxbService.GetAllNXB();
            dgvNXB.DataSource = null;
            dgvNXB.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemNXB = new FormThemNXB())
            {
                var popup = formThemNXB.ShowDialog(this);
                if (popup == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var formSuaNXB = new FormSuaNXB())
            {
                formSuaNXB.ShowDialog(this);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietNXB = new FormChiTietNXB())
            {
                formChiTietNXB.ShowDialog(this);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNXB.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn NXB để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = (int)dgvNXB.CurrentRow.Cells["IdNXB"].Value;
            var comfirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa NXB này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (comfirm == DialogResult.No) return;
            try
            {
                _nxbService.DeleteNXB(id);
                MessageBox.Show("Xóa NXB thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa NXB thất bại.\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
