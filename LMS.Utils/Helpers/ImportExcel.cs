using ClosedXML.Excel;
using LMS.Models.Dtos;

namespace LMS.Views.LMS.Utils.Helpers
{
    public static class ImportExcel
    {
        public static List<SachExcelDto> ReadSachFromFile(string filePath)
        {
            var result = new List<SachExcelDto>();

            using var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet(1);

            var firstRowUsed = worksheet.FirstRowUsed();
            if (firstRowUsed == null)
            {
                return result;
            }

            var headerRowNumber = firstRowUsed.RowNumber();
            var lastRowNumber = worksheet.LastRowUsed().RowNumber();

            // Map tên cột -> index cột
            var headerCells = worksheet.Row(headerRowNumber).CellsUsed();
            var columnMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var cell in headerCells)
            {
                var header = cell.GetString().Trim();
                if (!string.IsNullOrEmpty(header) && !columnMap.ContainsKey(header))
                {
                    columnMap[header] = cell.Address.ColumnNumber;
                }
            }

            // Đọc từng dòng dữ liệu
            for (int row = headerRowNumber + 1; row <= lastRowNumber; row++)
            {
                var dataRow = worksheet.Row(row);

                // Bỏ qua dòng hoàn toàn trống
                if (dataRow.CellsUsed().All(c => string.IsNullOrWhiteSpace(c.GetString())))
                    continue;

                var dto = new SachExcelDto
                {
                    IdSach = 0, // bỏ qua Id khi import, để DB tự sinh
                    MaSach = GetString(dataRow, columnMap, "MaSach"),
                    TenSach = GetString(dataRow, columnMap, "TenSach"),
                    TenNXB = GetString(dataRow, columnMap, "TenNXB"),
                    TheLoai = GetString(dataRow, columnMap, "TheLoai"),
                    TacGia = GetString(dataRow, columnMap, "TacGia"),
                    NamXuatBan = GetInt(dataRow, columnMap, "NamXuatBan"),
                    SoTrang = GetInt(dataRow, columnMap, "SoTrang"),
                    SoLuongBanSao = 0, // không import số lượng bản sao
                    GiaTien = GetDecimal(dataRow, columnMap, "GiaTien"),
                    MoTa = GetString(dataRow, columnMap, "MoTa")
                };

                result.Add(dto);
            }

            return result;
        }

        public static List<NhapSachExcelDto> ReadNhapSachFromFile(string filePath)
        {
            var result = new List<NhapSachExcelDto>();

            using var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet(1);

            var firstRowUsed = worksheet.FirstRowUsed();
            if (firstRowUsed == null)
            {
                return result;
            }

            var headerRowNumber = firstRowUsed.RowNumber();
            var lastRowNumber = worksheet.LastRowUsed().RowNumber();

            var headerCells = worksheet.Row(headerRowNumber).CellsUsed();
            var columnMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var cell in headerCells)
            {
                var header = cell.GetString().Trim();
                if (!string.IsNullOrEmpty(header) && !columnMap.ContainsKey(header))
                {
                    columnMap[header] = cell.Address.ColumnNumber;
                }
            }

            for (int row = headerRowNumber + 1; row <= lastRowNumber; row++)
            {
                var dataRow = worksheet.Row(row);

                if (dataRow.CellsUsed().All(c => string.IsNullOrWhiteSpace(c.GetString())))
                    continue;

                var dto = new NhapSachExcelDto
                {
                    MaSach = GetString(dataRow, columnMap, "MaSach"),
                    SoLuongNhap = GetInt(dataRow, columnMap, "SoLuongNhap"),
                    GiaTien = GetDecimal(dataRow, columnMap, "GiaTien")
                };

                result.Add(dto);
            }

            return result;
        }

        private static string GetString(IXLRow row, Dictionary<string, int> map, string columnName)
        {
            if (!map.TryGetValue(columnName, out var colIndex))
                return string.Empty;
            return row.Cell(colIndex).GetString().Trim();
        }

        private static int GetInt(IXLRow row, Dictionary<string, int> map, string columnName)
        {
            if (!map.TryGetValue(columnName, out var colIndex))
                return 0;

            var cell = row.Cell(colIndex);
            if (cell.DataType == XLDataType.Number && int.TryParse(cell.GetValue<double>().ToString(), out var numFromNumber))
            {
                return numFromNumber;
            }

            if (int.TryParse(cell.GetString(), out var numFromString))
            {
                return numFromString;
            }

            return 0;
        }

        private static decimal GetDecimal(IXLRow row, Dictionary<string, int> map, string columnName)
        {
            if (!map.TryGetValue(columnName, out var colIndex))
                return 0m;

            var cell = row.Cell(colIndex);

            if (cell.DataType == XLDataType.Number && decimal.TryParse(cell.GetValue<double>().ToString(), out var numFromNumber))
            {
                return numFromNumber;
            }

            if (decimal.TryParse(cell.GetString(), out var numFromString))
            {
                return numFromString;
            }

            return 0m;
        }
    }
}


