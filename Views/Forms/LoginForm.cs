using LMS.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            // xu ly logic dang nhap truoc
            if (textBoxTenDangNhap.Text == "" && textBoxMatKhau.Text == "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tai khoan / mat khau");
            }

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void checkBoxAnHien_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMatKhau.UseSystemPasswordChar = !checkBoxAnHien.Checked;  
        }
    }
}
