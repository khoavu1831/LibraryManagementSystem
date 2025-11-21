using LMS.Entities;
using LMS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLPhat
{
    public partial class FormChiTietMucPhat : Form
    {
        private readonly int _idMucPhat;
        public FormChiTietMucPhat(int idMucPhat, string tenMucPhat, MucPhat.LoaiPhatEnum loaiPhat, string moTa, decimal soTien)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            _idMucPhat = idMucPhat;

            // Hiển thị enum có dấu trong ComboBox
            var loaiPhatList = Enum.GetValues(typeof(MucPhat.LoaiPhatEnum))
                .Cast<MucPhat.LoaiPhatEnum>()
                .Select(e => new { Value = e, Display = e.GetDisplayName() })
                .ToList();
            
            comboBoxLoaiPhat.DataSource = loaiPhatList;
            comboBoxLoaiPhat.DisplayMember = "Display";
            comboBoxLoaiPhat.ValueMember = "Value";
            
            textBoxIDMucPhat.Text = idMucPhat.ToString();
            textBoxTenMucPhat.Text = tenMucPhat;
            textBoxMoTa.Text = moTa;
            textBoxSoTien.Text = soTien.ToString("N0"); // Format số tiền với dấu phân cách hàng nghìn
            comboBoxLoaiPhat.SelectedValue = loaiPhat;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
