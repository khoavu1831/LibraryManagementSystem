using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using LMS.Services;
using LMS.Helpers;

namespace LMS.Views.UserControls.QLPhat
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
            
            // Chỉ check parse được không, không check logic
            if (!decimal.TryParse(textBoxSoTien.Text.Trim(), out soTienPhat))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ (phải là số).", "Cảnh báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var soTienPhat)) return;

            var mucPhat = new MucPhat
            {
                TenMucPhat = textBoxTenMucPhat.Text.Trim(),  // Cứ lấy, để Service validate
                SoTienPhat = soTienPhat,
                MoTa = textBoxMoTa.Text.Trim(),
                LoaiPhat = (MucPhat.LoaiPhatEnum)comboBoxLoaiPhat.SelectedValue
            };

            try
            {
                _mucPhatService.Save(mucPhat);  // Service sẽ validate hết
                MessageBox.Show("Thêm Mức Phạt thành công.", "Thành công", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
