using LMS.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Views.UserControls.QLSach
{
    public partial class UcQLSach : UserControl
    {
        private readonly List<string> _permissions;

        public UcQLSach(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();

            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định: Ưu tiên Sach nếu có quyền, sau đó TacGia, BanSaoSach, NXB, TheLoai
            UserControl defaultUc = null;
            if (HasPermissionForSach())
            {
                defaultUc = new UcSach(_permissions);
            }
            else if (HasPermissionForTacGia())
            {
                defaultUc = new UcTacGia(_permissions);
            }
            else if (HasPermissionForBanSaoSach())
            {
                defaultUc = new UcBanSaoSach(_permissions);
            }
            else if (HasPermissionForNXB())
            {
                defaultUc = new UcNXB(_permissions);
            }
            else if (HasPermissionForTheLoai())
            {
                defaultUc = new UcTheLoai(_permissions);
            }
            // Nếu không có quyền nào, panelSubContent sẽ trống (hoặc có thể load một thông báo lỗi nếu cần)

            if (defaultUc != null)
            {
                LoadSubControl(defaultUc);
            }
        }

        private void HideAllSubButtons()
        {
            btnSach.Visible = false;
            btnTacGia.Visible = false;
            btnBanSaoSach.Visible = false;
            btnNXB.Visible = false;
            btnTheLoai.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Sách: Permissions SACH_*
            if (HasPermissionForSach())
            {
                btnSach.Visible = true;
            }

            // Sub-module Tác giả: Permissions TACGIA_*
            if (HasPermissionForTacGia())
            {
                btnTacGia.Visible = true;
            }

            // Sub-module Bản sao sách: Permissions SACH_BANSAO_*
            if (HasPermissionForBanSaoSach())
            {
                btnBanSaoSach.Visible = true;
            }

            // Sub-module Nhà xuất bản: Permissions NHAXUATBAN_*
            if (HasPermissionForNXB())
            {
                btnNXB.Visible = true;
            }

            // Sub-module Thể loại: Permissions THELOAI_*
            if (HasPermissionForTheLoai())
            {
                btnTheLoai.Visible = true;
            }
        }

        private bool HasPermissionForSach()
        {
            return _permissions.Any(p => p.StartsWith("SACH_"));
        }

        private bool HasPermissionForTacGia()
        {
            return _permissions.Any(p => p.StartsWith("TACGIA_"));
        }

        private bool HasPermissionForBanSaoSach()
        {
            return _permissions.Any(p => p.StartsWith("SACH_BANSAO_"));
        }

        private bool HasPermissionForNXB()
        {
            return _permissions.Any(p => p.StartsWith("NHAXUATBAN_"));
        }

        private bool HasPermissionForTheLoai()
        {
            return _permissions.Any(p => p.StartsWith("THELOAI_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            if (btnSach.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadSubControl(new UcSach(_permissions));
            }
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            if (btnTacGia.Visible)
            {
                LoadSubControl(new UcTacGia(_permissions));
            }
        }

        private void btnBanSaoSach_Click(object sender, EventArgs e)
        {
            if (btnBanSaoSach.Visible)
            {
                LoadSubControl(new UcBanSaoSach(_permissions));
            }
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            if (btnNXB.Visible)
            {
                LoadSubControl(new UcNXB(_permissions));
            }
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            if (btnTheLoai.Visible)
            {
                LoadSubControl(new UcTheLoai(_permissions));
            }
        }
    }
}