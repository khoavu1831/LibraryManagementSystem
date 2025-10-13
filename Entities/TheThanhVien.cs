using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Entities
{
    [Table("TheThanhVien")]
    public class TheThanhVien
    {
        [Key]
        public int IdTheThanhVien { get; set; }
        public int IdDocGia { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public TrangThaiEnum TrangThai { get; set; }

        [ForeignKey("IdDocGia")]
        public DocGia? DocGias { get; set; }
        public ICollection<PhieuMuon>? PhieuMuons { get; set; }
        public enum TrangThaiEnum
        {

            [Display(Name = "Hoạt động")]
            HoatDong,
            [Display(Name = "Bị khóa")]
            BiKhoa,
            [Display(Name = "Hết hạn")]
            HetHan
        }

    }
}
