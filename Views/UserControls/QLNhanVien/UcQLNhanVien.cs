using LMS.Views.UserControls.QLNhanVien.NhanVien;
using LMS.Views.UserControls.QLNhanVien.Quyen;
using LMS.Views.UserControls.QLNhanVien.TaiKhoan;
using LMS.Views.UserControls.QLNhanVien.VaiTro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhanVien
{
    public partial class UcQLNhanVien : UserControl
    {
        private readonly List<string> _permissions;

        public UcQLNhanVien(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();

            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định: Ưu tiên NhanVien nếu có quyền, sau đó TaiKhoan, VaiTro, Quyen
            UserControl defaultUc = null;
            if (HasPermissionForNhanVien())
            {
                defaultUc = new UcNhanVien(_permissions);
            }
            else if (HasPermissionForTaiKhoan())
            {
                defaultUc = new UcTaiKhoan(_permissions);
            }
            else if (HasPermissionForVaiTro())
            {
                defaultUc = new UcVaiTro(_permissions);
            }
            else if (HasPermissionForQuyen())
            {
                defaultUc = new UcQuyen();
            }
            // Nếu không có quyền nào, panelSubContent sẽ trống (hoặc có thể load một thông báo lỗi nếu cần)

            if (defaultUc != null)
            {
                LoadSubControl(defaultUc);
            }
        }

        private void HideAllSubButtons()
        {
            btnNhanVien.Visible = false;
            btnTaiKhoan.Visible = false;
            btnVaiTro.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Nhân viên: Permissions NHANVIEN_*
            if (HasPermissionForNhanVien())
            {
                btnNhanVien.Visible = true;
            }

            // Sub-module Tài khoản: Permissions TAIKHOAN_*
            if (HasPermissionForTaiKhoan())
            {
                btnTaiKhoan.Visible = true;
            }

            // Sub-module Vai trò: Permissions VAITRO_*
            if (HasPermissionForVaiTro())
            {
                btnVaiTro.Visible = true;
            }
        }

        private bool HasPermissionForNhanVien()
        {
            return _permissions.Any(p => p.StartsWith("NHANVIEN_"));
        }

        private bool HasPermissionForTaiKhoan()
        {
            return _permissions.Any(p => p.StartsWith("TAIKHOAN_"));
        }

        private bool HasPermissionForVaiTro()
        {
            return _permissions.Any(p => p.StartsWith("VAITRO_"));
        }

        private bool HasPermissionForQuyen()
        {
            // Giả sử Quyen liên quan đến quản lý quyền, check VAITRO_* (vì quyền gắn với vai trò)
            // Nếu có prefix riêng như "QUYEN_*", thay bằng p.StartsWith("QUYEN_")
            return _permissions.Any(p => p.StartsWith("VAITRO_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (btnNhanVien.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadSubControl(new UcNhanVien(_permissions));
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (btnTaiKhoan.Visible)
            {
                LoadSubControl(new UcTaiKhoan(_permissions));
            }
        }

        private void btnVaiTro_Click(object sender, EventArgs e)
        {
            if (btnVaiTro.Visible)
            {
                LoadSubControl(new UcVaiTro(_permissions));
            }
        }

    }
}