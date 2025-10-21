using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null) return value.ToString();

            // Thử lấy DisplayAttribute trước
            var displayAttribute = (DisplayAttribute?)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));
            if (displayAttribute != null && displayAttribute.Name != null)
                return displayAttribute.Name;

            // Nếu không có thì thử DescriptionAttribute
            var descriptionAttribute = (DescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            if (descriptionAttribute != null)
                return descriptionAttribute.Description;

            // Mặc định trả về tên enum
            return value.ToString();
        }
    }
}
