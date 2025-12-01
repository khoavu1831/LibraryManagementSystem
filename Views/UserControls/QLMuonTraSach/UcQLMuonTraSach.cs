using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLMuonTraSach
{
    public partial class UcQLMuonTraSach : UserControl
    {
        private readonly List<string> _permissions;

        public UcQLMuonTraSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();

            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định nếu có quyền
            if (HasPermissionForMuonTraSach())
            {
                LoadSubControl(new UcMuonTraSach(_permissions));
            }
            // Nếu không có quyền, panelSubContent sẽ trống
        }

        private void HideAllSubButtons()
        {
            btnMuonTraSach.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Mượn-trả sách: Permissions MUONTRA_* (cho cả mượn và trả, vì không phân biệt rõ)
            if (HasPermissionForMuonTraSach())
            {
                // Hiển thị cả hai button vì chúng load cùng control và permissions chung
                btnMuonTraSach.Visible = true;
            }
        }

        private bool HasPermissionForMuonTraSach()
        {
            return _permissions.Any(p => p.StartsWith("MUONTRA_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (btnMuonTraSach.Visible)
            {
                LoadSubControl(new UcMuonTraSach(_permissions));
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
        }

        private void labelTrang_Click(object sender, EventArgs e)
        {
        }
    }
}