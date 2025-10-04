using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class FormSuaTraSach : Form
    {
        public FormSuaTraSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            textBoxNhanVien.Text = "NV1 - Nguyễn A";
            textBoxThanhVien.Text = "TV101 - Lê C";
            textBoxNgayMuon.Text = DateTime.Now.AddDays(-7).ToShortDateString();
            textBoxHanTra.Text = DateTime.Now.ToShortDateString();
            dateTimePickerNgayTra.Value = DateTime.Now;

            checkedListBoxSach.Items.Clear();
            checkedListBoxSach.Items.Add("Bản sao #001 - Lập trình C#");
            checkedListBoxSach.Items.Add("Bản sao #002 - Cơ sở dữ liệu");
            checkedListBoxSach.Items.Add("Bản sao #003 - Hệ điều hành");

            checkedListBoxSach.SetItemChecked(0, true);
            checkedListBoxSach.SetItemChecked(1, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã cập nhật thông tin phiếu trả. (Thêm logic DB vào)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}