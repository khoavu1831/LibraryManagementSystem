using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Views.UserControls.QLPhat;

namespace LMS.Views.UserControls.QLPhat
{
    public partial class UcQLPhat : UserControl
    {
        private readonly List<string> _permissions;
            
        public UcQLPhat(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();
         


            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định: Ưu tiên Phat nếu có quyền, sau đó TraPhat, MucPhat
            UserControl defaultUc = null;
            if (HasPermissionForPhat())
            {
                defaultUc = new UcPhat(_permissions);
            }
            else if (HasPermissionForTraPhat())
            {
                defaultUc = new UcTraPhat(_permissions);
            }
            else if (HasPermissionForMucPhat())
            {
                defaultUc = new UcMucPhat(_permissions);
            }
            // Nếu không có quyền nào, panelSubContent sẽ trống (hoặc có thể load một thông báo lỗi nếu cần)

            if (defaultUc != null)
            {
                LoadSubControl(defaultUc);
            }
        }

        private void HideAllSubButtons()
        {
            btnPhat.Visible = false;
            btnMucPhat.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Phạt: Permissions PHAT_*
            if (HasPermissionForPhat())
            {
                btnPhat.Visible = true;
            }

            // Sub-module Mức Phạt: Permissions MUC_PHAT_*
            if (HasPermissionForMucPhat())
            {
                btnMucPhat.Visible = true;
            }
        }

        private bool HasPermissionForPhat()
        {
            return _permissions.Any(p => p.StartsWith("PHAT_"));
        }

        private bool HasPermissionForTraPhat()
        {
            // Nếu có prefix riêng, chỉnh ở đây
            return _permissions.Any(p => p.StartsWith("TRAPHAT_"));
        }

        private bool HasPermissionForMucPhat()
        {
            return _permissions.Any(p => p.StartsWith("MUC_PHAT_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Clear();
            panelSubContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            if (btnPhat.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadSubControl(new UcPhat(_permissions));

            }
        }

        private void btnMucPhat_Click(object sender, EventArgs e)
        {
            if (btnMucPhat.Visible)
            {
                LoadSubControl(new UcMucPhat(_permissions));
            }
        }
    }
}