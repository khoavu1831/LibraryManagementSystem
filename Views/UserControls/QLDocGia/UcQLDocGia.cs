using LMS.Views.UserControls.QLDocGia.KhachHang;
using LMS.Views.UserControls.QLDocGia.TheThanhVien;
using System.Linq;

namespace LMS.Views.UserControls.QLDocGia
{
    public partial class UcQLDocGia : UserControl
    {
        private readonly List<string> _permissions;

        public UcQLDocGia(List<string> permissions)
        {
            InitializeComponent();
            _permissions = permissions ?? new List<string>();

            // Ẩn tất cả các sub-button trước khi kiểm tra permissions
            HideAllSubButtons();

            // Kiểm tra và hiển thị sub-buttons dựa trên permissions
            SetupSubButtonVisibility();

            // Load sub-control mặc định: Ưu tiên Khách hàng nếu có quyền, sau đó là Thẻ thành viên
            UserControl defaultUc = null;
            if (HasPermissionForKhachHang())
            {
                defaultUc = new UcKhachHang(_permissions);
            }
            else if (HasPermissionForTheThanhVien())
            {
                defaultUc = new UcTheThanhVien(_permissions);
            }
            // Nếu không có quyền nào, panelSubContent sẽ trống (hoặc có thể load một thông báo lỗi nếu cần)

            if (defaultUc != null)
            {
                LoadSubControl(defaultUc);
            }
        }

        private void HideAllSubButtons()
        {
            btnKhachHang.Visible = false;
            btnTheThanhVien.Visible = false;
        }

        private void SetupSubButtonVisibility()
        {
            // Sub-module Khách hàng: Permissions KHACHHANG_*
            if (HasPermissionForKhachHang())
            {
                btnKhachHang.Visible = true;
            }

            // Sub-module Thẻ thành viên: Permissions THE_THANHVIEN_*, THETHANHVIEN_*
            if (HasPermissionForTheThanhVien())
            {
                btnTheThanhVien.Visible = true;
            }
        }

        private bool HasPermissionForKhachHang()
        {
            return _permissions.Any(p => p.StartsWith("KHACHHANG_"));
        }

        private bool HasPermissionForTheThanhVien()
        {
            return _permissions.Any(p => p.StartsWith("THETHANHVIEN_"));
        }

        private void LoadSubControl(UserControl uc)
        {
            panelSubContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelSubContent.Controls.Add(uc);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (btnKhachHang.Visible) // Chỉ load nếu button visible (có quyền)
            {
                LoadSubControl(new UcKhachHang(_permissions));
            }
        }

        private void btnTheThanhVien_Click(object sender, EventArgs e)
        {
            if (btnTheThanhVien.Visible)
            {
                LoadSubControl(new UcTheThanhVien(_permissions));
            }
        }
    }
}