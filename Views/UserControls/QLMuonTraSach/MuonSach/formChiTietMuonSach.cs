using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    public partial class FormChiTietMuonSach : Form
    {
        public FormChiTietMuonSach()
        {
            InitializeComponent();
            LoadDemoData(); // test thôi
        }

        public FormChiTietMuonSach(string nhanVien, string thanhVien, DateTime ngayMuon, DateTime hanTra, List<string> sachMuon)
        {
            InitializeComponent();
            SetData(nhanVien, thanhVien, ngayMuon, hanTra, sachMuon);
        }

        private void LoadDemoData()
        {
            SetData(
                "Nguyễn Văn A",
                "Trần Thị B",
                DateTime.Now.AddDays(-3),
                DateTime.Now.AddDays(7),
                new List<string>
                {
                    "Bản sao #001 - Lập trình C#",
                    "Bản sao #003 - Cơ sở dữ liệu"
                }
            );
        }

        private void SetData(string nhanVien, string thanhVien, DateTime ngayMuon, DateTime hanTra, List<string> sachMuon)
        {
            lblNhanVienValue.Text = nhanVien;
            lblThanhVienValue.Text = thanhVien;
            lblNgayMuonValue.Text = ngayMuon.ToString("dd/MM/yyyy");
            lblHanTraValue.Text = hanTra.ToString("dd/MM/yyyy");

            listBoxSach.Items.Clear();
            foreach (var s in sachMuon)
                listBoxSach.Items.Add(s);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}