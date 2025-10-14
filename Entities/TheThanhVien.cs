using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DocGia? DocGia { get; set; }
        public ICollection<PhieuMuon>? PhieuMuons { get; set; }
        public enum TrangThaiEnum
        {
            HoatDong, 
            BiKhoa,
            HetHan
        }

    }
}
