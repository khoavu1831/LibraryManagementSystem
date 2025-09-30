using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLPhat.Phat
{
    public partial class FormThemPhieuPhat : Form
    {
        public FormThemPhieuPhat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (cboPhieuMuon.SelectedValue == null || cboMucPhat.SelectedValue == null)
            //{
            //    MessageBox.Show("Chọn đầy đủ phiếu mượn và mục phạt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var confirm = MessageBox.Show(
            //    "Phiếu phạt sau khi tạo sẽ không thể chỉnh sửa.\nBạn có chắc chắn muốn tạo?",
            //    "Xác nhận",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning
            //);

            //if (confirm != DialogResult.Yes) return;

            // chỗ này gọi DbContext để Add và SaveChanges
        }
    }
}
