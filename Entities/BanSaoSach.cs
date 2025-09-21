using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("BanSaoSach")]
    public class BanSaoSach
    {
        [Key]
        public int IdBanSaoSach { get; set; }
        public int IdSach { get; set; }
        public TinhTrangSachEnum TinhTrangSach { get; set; }

        [ForeignKey("IdSach")]
        public Sach? Sach { get; set; }
        public ICollection<ChiTietPhieuMuon>? ChiTietPhieuMuons { get; set; }
        public enum TinhTrangSachEnum
        {
            Tot, Hong, Mat, ChoMuon
        }
    }
}
