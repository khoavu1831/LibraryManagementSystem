using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;//  để nhận LibraryDbContext
using LMS.Helpers; // để nhận CurrentUserContext

namespace LMS.Views.UserControls.QuanLy
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

       

        private void btnXong_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryDbContext())
            {
                var tk = db.TaiKhoans.FirstOrDefault(x => x.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);

                if (tk != null && tk.MatKhau == txtMatKhauCu.Text)
                {
                    if (textmkm.Text == textnhaplaimk.Text)
                    {
                        tk.MatKhau = textmkm.Text;
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!");
                }
            }
        }
    }
}
