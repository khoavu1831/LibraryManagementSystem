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
    public partial class FormThemTraSach : Form
    {
        public FormThemTraSach()
        {
            InitializeComponent();
            LoadLookupData();
        }

        private void LoadLookupData()
        {
            comboBoxNhanVien.DisplayMember = "Name";
            comboBoxNhanVien.ValueMember = "Id";
            comboBoxNhanVien.DataSource = new List<dynamic>
            {
                new { Id = 1, Name = "NV1 - Nguyễn A" },
                new { Id = 2, Name = "NV2 - Trần B" }
            };

            comboBoxThanhVien.DisplayMember = "Name";
            comboBoxThanhVien.ValueMember = "Id";
            comboBoxThanhVien.DataSource = new List<dynamic>
            {
                new { Id = 101, Name = "TV101 - Lê C" },
                new { Id = 102, Name = "TV102 - Phạm D" }
            };

            checkedListBoxSach.Items.Clear();
            checkedListBoxSach.Items.Add("Bản sao #001 - Lập trình C#");
            checkedListBoxSach.Items.Add("Bản sao #002 - Cơ sở dữ liệu");
            checkedListBoxSach.Items.Add("Bản sao #003 - Hệ điều hành");

            dateTimePickerNgayTra.Value = DateTime.Now.Date;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã tạo phiếu trả. (Thêm logic DB vào)",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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