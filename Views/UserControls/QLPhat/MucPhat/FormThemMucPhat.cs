using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Helpers;

namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class FormThemMucPhat : Form
    {
        private readonly MucPhatService _mucPhatService;

        public FormThemMucPhat()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            var mucPhatRepository = new MucPhatRepository(context);
            _mucPhatService = new MucPhatService(mucPhatRepository);
            
            // Hiển thị enum có dấu trong ComboBox
            var loaiPhatList = Enum.GetValues(typeof(MucPhat.LoaiPhatEnum))
                .Cast<MucPhat.LoaiPhatEnum>()
                .Select(e => new { Value = e, Display = e.GetDisplayName() })
                .ToList();
            
            comboBoxLoaiPhat.DataSource = loaiPhatList;
            comboBoxLoaiPhat.DisplayMember = "Display";
            comboBoxLoaiPhat.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs(out decimal soTienPhat)
        {
            soTienPhat = 0;
            if (string.IsNullOrWhiteSpace(textBoxTenMucPhat.Text))
            {
                MessageBox.Show("Tên mức phạt không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(textBoxSoTien.Text.Trim(), out soTienPhat))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var soTienPhat)) return;

            var mucPhat = new MucPhat
            {
                TenMucPhat = textBoxTenMucPhat.Text.Trim(),
                SoTienPhat = soTienPhat,
                MoTa = textBoxMoTa.Text.Trim(),
                LoaiPhat = (MucPhat.LoaiPhatEnum)comboBoxLoaiPhat.SelectedValue
            };

            try
            {
                _mucPhatService.Save(mucPhat);
                MessageBox.Show("Thêm Mức Phạt thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
