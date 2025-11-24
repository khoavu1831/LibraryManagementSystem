using System.ComponentModel.DataAnnotations;

namespace LMS.Models.Dtos
{
    public class BanSaoSachExcelDto
    {
        public string IdBanSaoSach { get; set; }
        public int IdSach { get; set; }
        public string TenSach { get; set; }
        public TinhTrangSachEnum TinhTrangSach { get; set; }

        public enum TinhTrangSachEnum
        {
            [Display(Name = "Tốt")]
            Tot,
            [Display(Name = "Hỏng")]
            Hong,
            [Display(Name = "Mất")]
            Mat,
            [Display(Name = "Cho mượn")]
            ChoMuon
        }
    }
}
