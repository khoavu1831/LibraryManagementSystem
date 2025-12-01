using LMS.Forms;
using LMS.Views.UserControls.QLDocGia;
using LMS.Views.UserControls.QLMuonTraSach;
using LMS.Views.UserControls.QLNhanVien;
using LMS.Views.UserControls.QLPhat;
using LMS.Views.UserControls.QLThongKe;
using LMS.Views.UserControls.QLSach;
using LMS.Views.UserControls.TrangChu;
using LMS.Views.UserControls.QLNhapSach;
using LMS.Views.UserControls.QuanLy;
using LMS.Helpers;
using LMS.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LMS.Views.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<string> _userPermissions;
        private readonly UcTrangChu _ucTrangChu;
        private readonly UcQLSach _ucQLSach;
        private readonly UcQLNhapSach _ucQLNhapSach;
        private readonly UcQLNhanVien _ucQLNhanVien;
        private readonly UcQLPhat _ucQLPhat;
        private readonly UcQLMuonTraSach _ucQLMuonTraSach;
        private readonly UcQLThongKe _ucQLThongKe;
        private readonly UcQLDocGia _ucQLDocGia;
        private readonly UcQuanLy _ucQuanLy;

        public MainForm(List<string> userPermissions)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            _userPermissions = userPermissions ?? new List<string>();

            if (CurrentUserContext.CurrentUser != null)
            {
                using (var db = new LibraryDbContext())
                {
                    var nv = db.NhanViens
                               .Include(n => n.TaiKhoan)
                               .FirstOrDefault(n => n.IdTaiKhoan == CurrentUserContext.CurrentUser.IdTaiKhoan);
                    if (nv != null)
                    {
                        labelUsername.Text = nv.TenNhanVien;
                    }
                    else
                        labelUsername.Text = CurrentUserContext.CurrentUser.TenTaiKhoan;
                }
            }

            _ucTrangChu = new UcTrangChu();
            _ucQLSach = new UcQLSach(_userPermissions);
            _ucQLNhapSach = new UcQLNhapSach(_userPermissions);
            _ucQLNhanVien = new UcQLNhanVien(_userPermissions);
            _ucQLPhat = new UcQLPhat(_userPermissions);
            _ucQLMuonTraSach = new UcQLMuonTraSach(_userPermissions);
            _ucQLThongKe = new UcQLThongKe();
            _ucQLDocGia = new UcQLDocGia(_userPermissions);
            _ucQuanLy = new UcQuanLy();

            // Ẩn tất cả các button module trước khi kiểm tra permissions
            HideAllModuleButtons();

            // Kiểm tra và hiển thị buttons dựa trên permissions
            SetupModuleVisibility();

            // Load Trang chủ mặc định (luôn hiển thị)
            LoadUserControl(_ucTrangChu);
        }

        private void HideAllModuleButtons()
        {
            btnQLSach.Visible = false;
            buttonQLNhanVien.Visible = false;
            buttonQLMuonTraSach.Visible = false;
            btnPhat.Visible = false;
            btnNhapSach.Visible = false;
            btnQLThongKe.Visible = false;
            btnDocGia.Visible = false;
            // btnTrangChu và btnLogout luôn hiển thị, không cần ẩn
            // pictureBoxAvatar cũng luôn hiển thị (quản lý cá nhân)
        }

        private void SetupModuleVisibility()
        {
            // Module Sách: Sách, Bản sao sách, Tác giả, Nhà xuất bản, Thể loại
            // Permissions: SACH_*, SACH_BANSAO_*, TACGIA_*, NHAXUATBAN_*, THELOAI_*
            if (HasPermissionInModule("Sach"))
            {
                btnQLSach.Visible = true;
            }

            // Module Thành viên: Khách hàng, Thẻ thành viên
            // Permissions: KHACHHANG_*, THE_THANHVIEN_*, THETHANHVIEN_*
            if (HasPermissionInModule("ThanhVien"))
            {
                btnDocGia.Visible = true;
            }

            // Module Mượn-trả sách
            // Permissions: MUONTRA_*
            if (HasPermissionInModule("MuonTraSach"))
            {
                buttonQLMuonTraSach.Visible = true;
            }

            // Module Phạt-Trả phạt: Phạt, Mức phạt
            // Permissions: PHAT_*, MUC_PHAT_*
            if (HasPermissionInModule("Phat"))
            {
                btnPhat.Visible = true;
            }

            // Module Nhập sách: Nhập sách, Nhà cung cấp
            // Permissions: NHAPSACH_*, NHACUNGCAP_*
            if (HasPermissionInModule("NhapSach"))
            {
                btnNhapSach.Visible = true;
            }

            // Module Nhân viên: Nhân viên, Tài khoản, Vai trò
            // Permissions: NHANVIEN_*, TAIKHOAN_*, VAITRO_*
            if (HasPermissionInModule("NhanVien"))
            {
                buttonQLNhanVien.Visible = true;
            }

            // Module Thống kê: Luôn hiển thị hoặc check nếu có THONGKE_*
            // Permissions: THONGKE_*
            if (HasPermissionInModule("ThongKe") || _userPermissions.Any(p => p.StartsWith("THONGKE_")))
            {
                btnQLThongKe.Visible = true;
            }
        }

        private bool HasPermissionInModule(string module)
        {
            return module switch
            {
                "Sach" => _userPermissions.Any(p =>
                    p.StartsWith("SACH_") ||
                    p.StartsWith("SACH_BANSAO_") ||
                    p.StartsWith("TACGIA_") ||
                    p.StartsWith("NHAXUATBAN_") ||
                    p.StartsWith("THELOAI_")),

                "ThanhVien" => _userPermissions.Any(p =>
                    p.StartsWith("KHACHHANG_") ||
                    p.StartsWith("THE_THANHVIEN_") ||
                    p.StartsWith("THETHANHVIEN_")),

                "MuonTraSach" => _userPermissions.Any(p => p.StartsWith("MUONTRA_")),

                "Phat" => _userPermissions.Any(p =>
                    p.StartsWith("PHAT_") ||
                    p.StartsWith("MUC_PHAT_")),

                "NhapSach" => _userPermissions.Any(p =>
                    p.StartsWith("NHAPSACH_") ||
                    p.StartsWith("NHACUNGCAP_")),

                "NhanVien" => _userPermissions.Any(p =>
                    p.StartsWith("NHANVIEN_") ||
                    p.StartsWith("TAIKHOAN_") ||
                    p.StartsWith("VAITRO_")),

                _ => false
            };
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadUserControl(_ucTrangChu);
            HighlightButton((Button)sender);
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            if (btnQLSach.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadUserControl(_ucQLSach);
                HighlightButton((Button)sender);
            }
        }

        private void buttonQLNhanVien_Click(object sender, EventArgs e)
        {
            if (buttonQLNhanVien.Visible)
            {
                LoadUserControl(_ucQLNhanVien);
                HighlightButton((Button)sender);
            }
        }

        private void buttonQLMuonTraSach_Click(object sender, EventArgs e)
        {
            if (buttonQLMuonTraSach.Visible)
            {
                LoadUserControl(_ucQLMuonTraSach);
                HighlightButton((Button)sender);
            }
        }

        private void bntPhat_Click(object sender, EventArgs e)
        {
            if (btnPhat.Visible)
            {
                LoadUserControl(_ucQLPhat);
                HighlightButton((Button)sender);
            }
        }

        private void btnQLNhapSach_Click(object sender, EventArgs e)
        {
            if (btnNhapSach.Visible)
            {
                LoadUserControl(_ucQLNhapSach);
                HighlightButton((Button)sender);
            }
        }

        private void btnQLThongKe_Click(object sender, EventArgs e)
        {
            if (btnQLThongKe.Visible)
            {
                LoadUserControl(_ucQLThongKe);
                HighlightButton((Button)sender);
            }
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            if (btnDocGia.Visible)
            {
                LoadUserControl(_ucQLDocGia);
                HighlightButton((Button)sender);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            using (LoginForm loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var newMainForm = new MainForm(loginForm.UserPermissions);
                    newMainForm.Show();
                }
                else
                {
                    Close();
                }
            }
        }

        private void ResetMenuColors()
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void HighlightButton(Button btn)
        {
            ResetMenuColors();
            btn.BackColor = Color.LightSeaGreen;
            btn.ForeColor = Color.White;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxAvatar_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(_ucQuanLy);
        }
    }
}