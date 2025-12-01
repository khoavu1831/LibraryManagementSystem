namespace LMS.Models.Dtos
{
    public class SachExcelDto
    {
        public int IdSach { get; set; }
        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public string TenNXB { get; set; } = string.Empty;
        public string TheLoai { get; set; } = string.Empty;
        public string TacGia { get; set; } = string.Empty;
        public int NamXuatBan { get; set; }
        public int SoTrang { get; set; }
        public int SoLuongBanSao { get; set; }
        public decimal GiaTien { get; set; }
        public string MoTa { get; set; } = string.Empty;
    }
}


