using ClosedXML.Excel;
using System.Data;
namespace LMS.Views.LMS.Utils.Helpers
{
    public class ExportExcel
    {
        public static MemoryStream Export<T>(List<T> data, string name, string[] notUse)
        {
            var dt = new DataTable(typeof(T).Name);


            // Lấy tất cả property của T
            var props = typeof(T).GetProperties();

            // Nếu có mảng notUse, lọc bỏ các property trong mảng này
            if (notUse != null && notUse.Length > 0)
            {
                props = props.Where(p => !notUse.Contains(p.Name)).ToArray();
            }

            // Tạo cột
            foreach (var prop in props)
                dt.Columns.Add(prop.Name);
            // Thêm dữ liệu
            foreach (var item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                    values[i] = props[i].GetValue(item, null);
                dt.Rows.Add(values);
            }

            // Tạo Excel
            var stream = new MemoryStream();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(name);
                worksheet.Cell(1, 1).InsertTable(dt);
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(stream);
            }
            return stream;
        }
    }
}
