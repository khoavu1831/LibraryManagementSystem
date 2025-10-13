using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Helpers;
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

namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class FormSuaMucPhat : Form
    {
        private readonly int _idMucPhat;
        private readonly MucPhatService _mucPhatService;

        public FormSuaMucPhat(int idMucPhat, string tenMucPhat, decimal soTien, string moTa, MucPhat.LoaiPhatEnum loaiPhat)
        {
            InitializeComponent();
            
            var context = new LibraryDbContext();
            var mucPhatRepository = new MucPhatRepository(context);
            _mucPhatService = new MucPhatService(mucPhatRepository);
            
            _idMucPhat = idMucPhat;

            // Hiển thị enum có dấu trong ComboBox
            var loaiPhatList = Enum.GetValues(typeof(MucPhat.LoaiPhatEnum))
                .Cast<MucPhat.LoaiPhatEnum>()
                .Select(e => new { Value = e, Display = e.GetDisplayName() })
                .ToList();
            
            comboBoxLoaiPhat.DataSource = loaiPhatList;
            comboBoxLoaiPhat.DisplayMember = "Display";
            comboBoxLoaiPhat.ValueMember = "Value";

            // Fill dữ liệu vào form
            textBoxTenMucPhat.Text = tenMucPhat;
            textBoxSoTien.Text = soTien.ToString("N0"); // Format với dấu phân cách hàng nghìn
            textBoxMoTa.Text = moTa;
            comboBoxLoaiPhat.SelectedValue = loaiPhat;
        }

        private bool ValidateInputs(out decimal soTienPhat)
        {
            soTienPhat = 0;
            
            // Chỉ validate format parse
            if (!decimal.TryParse(textBoxSoTien.Text.Trim().Replace(",", "").Replace(".", ""), out soTienPhat))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ (phải là số).", "Cảnh báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSoTien.Focus();
                return false;
            }
            
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var soTienPhat)) return;

            var mucPhat = new MucPhat
            {
                IdMucPhat = _idMucPhat, // Quan trọng: phải set ID để update
                TenMucPhat = textBoxTenMucPhat.Text.Trim(),
                SoTienPhat = soTienPhat,
                MoTa = textBoxMoTa.Text.Trim(),
                LoaiPhat = (MucPhat.LoaiPhatEnum)comboBoxLoaiPhat.SelectedValue
            };

            try
            {
                _mucPhatService.Save(mucPhat); // Service sẽ tự biết update vì IdMucPhat != 0
                MessageBox.Show("Sửa Mức Phạt thành công.", "Thành công", 
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

        private void textBoxHVT_TextChanged(object sender, EventArgs e)
        {
            // Event handler cũ, có thể xóa nếu không dùng
        }
    }
}