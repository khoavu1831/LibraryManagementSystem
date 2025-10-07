using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("Sach")]
    public class Sach
    {
        [Key]
        public int IdSach{ get; set; }
        [NotMapped]
        public string IdSachFormat => $"S{IdSach}";
        public int IdNXB { get; set; }
        public int NamXuatBan { get;set; }
        public string? TenSach { get; set; }
        public string? MoTa { get; set; }
        public int SoTrang { get; set; }
        public int SoLuongBanSao { get; set; }
        public decimal GiaTien { get; set; }
        [ForeignKey("IdNXB")]
        public NXB? NXB { get; set; }
        public ICollection<TheLoai>? TheLoais { get; set; }
        public ICollection<TacGia>? TacGias { get; set; }
        public ICollection<BanSaoSach>? BanSaoSachs { get; set; }
    }
}
