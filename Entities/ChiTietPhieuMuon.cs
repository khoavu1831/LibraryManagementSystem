using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("ChiTietPhieuMuon")]
    public class ChiTietPhieuMuon
    {
        [Key]
        public int IdChiTietPhieuMuon { get; set; }
        public int IdPhieuMuon { get; set; }
        public string? IdBanSaoSach { get; set; }

        public DateTime? NgayTra { get; set; }
        public TinhTrangTraEnum? TinhTrangTra { get; set; }

        [ForeignKey("IdPhieuMuon")]
        public PhieuMuon? PhieuMuon { get; set; }
        [ForeignKey("IdBanSaoSach")]
        public BanSaoSach? BanSaoSach { get; set; }

        public enum TinhTrangTraEnum
        {
            Tot,        
            HuHong,     
            Mat        
        }
    }
}
