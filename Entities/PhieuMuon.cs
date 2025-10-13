using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("PhieuMuon")]
    public class PhieuMuon
    {
        [Key]
        public int IdPhieuMuon { get; set; }
        public int IdNhanVien { get; set; }
        public int IdTheThanhVien { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }
        public TrangThaiEnum TrangThai { get; set; }

        [ForeignKey("IdNhanVien")]
        public NhanVien? NhanVien { get; set; }
        [ForeignKey("IdTheThanhVien")]
        public TheThanhVien? TheThanhVien { get; set; }
        public ICollection<ChiTietPhieuMuon>? ChiTietPhieuMuons { get; set; }

        public enum TrangThaiEnum
        {
            DangMuon,   
            DaTra,
            QuaHan     
        }
    }
}
