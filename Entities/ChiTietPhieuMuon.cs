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
        public int IdBanSaoSach { get; set; }
        public DateTime NgayTra { get; set; }
        public TinhTrangTraEnum TinhTrangTra { get; set; }
        
        [ForeignKey("IdPhieuMuon")]
        public PhieuMuon? PhieuMuon { get; set;}
        [ForeignKey("IdBanSaoSach")]
        public BanSaoSach? BanSaoSach { get; set; }
        public enum TinhTrangTraEnum
        {
            ChuaTra = 0,
            DaTra = 1,
            TreHen = 2,
            HongMat = 3
        }
    }
}
