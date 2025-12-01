using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class UcQLNhapSach : UserControl
    {
        private readonly List<string> _permissions;

        public UcQLNhapSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();

            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định: Ưu tiên NhapSach nếu có quyền, sau đó là NCC
            UserControl defaultUc = null;
            if (HasPermissionForNhapSach())
            {
                defaultUc = new UcNhapSach(_permissions);
            }
            else if (HasPermissionForNCC())
            {
                defaultUc = new UcNCC(_permissions);
            }
            // Nếu không có quyền nào, panelSubContent sẽ trống (hoặc có thể load một thông báo lỗi nếu cần)

            if (defaultUc != null)
            {
                LoadSubControl(defaultUc);
            }
        }

        private void HideAllSubButtons()
        {
            btnNhapSach.Visible = false;
            btnNCC.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Nhập sách: Permissions NHAPSACH_*
            if (HasPermissionForNhapSach())
            {
                btnNhapSach.Visible = true;
            }

            // Sub-module Nhà cung cấp: Permissions NHACUNGCAP_*
            if (HasPermissionForNCC())
            {
                btnNCC.Visible = true;
            }
        }

        private bool HasPermissionForNhapSach()
        {
            return _permissions.Any(p => p.StartsWith("NHAPSACH_"));
        }

        private bool HasPermissionForNCC()
        {
            return _permissions.Any(p => p.StartsWith("NHACUNGCAP_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            if (btnNhapSach.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadSubControl(new UcNhapSach(_permissions));
            }
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            if (btnNCC.Visible)
            {
                LoadSubControl(new UcNCC(_permissions));
            }
        }
    }
}