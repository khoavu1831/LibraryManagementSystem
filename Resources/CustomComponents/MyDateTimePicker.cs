using System;
using System.Windows.Forms;
using System.Drawing;

namespace LMS.Resources.CustomComponents
{
    public class MyDateTimePicker : DateTimePicker
    {
        private int _fillHeight = 0;

        // Ghi đè thuộc tính Height
        public new int Height
        {
            get
            {
                // Chỉ áp dụng logic custom khi KHÔNG ở chế độ thiết kế
                if (!DesignMode && (Dock == DockStyle.Fill || Dock == DockStyle.Left || Dock == DockStyle.Right))
                {
                    return (_fillHeight > 0) ? _fillHeight : base.Height;
                }
                return base.Height;
            }
            set
            {
                _fillHeight = value;
                base.Height = value;
            }
        }

        // Ghi đè SetBoundsCore
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Chỉ áp dụng logic custom khi KHÔNG ở chế độ thiết kế
            if (!DesignMode && (Dock == DockStyle.Fill || Dock == DockStyle.Left || Dock == DockStyle.Right))
            {
                // Thiết lập chiều cao mới vào thuộc tính đã ghi đè
                Height = height;

                // Gọi base với chiều cao đã được kiểm soát
                base.SetBoundsCore(x, y, width, this.Height, specified);
            }
            else
            {
                // Gọi base với giá trị mặc định khi ở chế độ thiết kế hoặc không Dock
                base.SetBoundsCore(x, y, width, height, specified);
            }
        }
    }
}