using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagementSystem.Resources.CustomComponents
{
    public class MyComboBox : ComboBox
    {

        public MyComboBox()
        {
            // Bắt buộc phải là OwnerDrawFixed để kiểm soát ItemHeight
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        // Ghi đè phương thức SetBoundsCore để bắt lấy chiều cao mới
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);

            // Chỉ thay đổi ItemHeight nếu ComboBox được Dock (Fill, Left, hoặc Right)
            if (Dock == DockStyle.Fill || Dock == DockStyle.Left || Dock == DockStyle.Right)
            {
                // Tính toán ItemHeight để lấp đầy chiều cao mới (height)
                // SystemInformation.FixedFrameBorderSize.Height là độ dày của viền
                var d = SystemInformation.FixedFrameBorderSize.Height;
                ItemHeight = height - 2 * d;
            }
            else
            {
                // Chiều cao mặc định khi không Dock
                ItemHeight = Font.Height + 2;
            }
        }

        // Ghi đè OnDrawItem để vẽ các mục khi DrawMode là OwnerDrawFixed
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Lấy văn bản từ mục hiện tại
            // Dòng 46 (đã sửa): Đảm bảo rằng itemText không bao giờ là null
            string text = (e.Index >= 0) ? GetItemText(e.Index) ?? string.Empty : string.Empty;

            // Vẽ văn bản
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, e.ForeColor,
                                  TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            base.OnDrawItem(e);
        }

    }
}
