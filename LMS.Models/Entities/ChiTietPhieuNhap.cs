using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("ChiTietPhieuNhap")]
    public class ChiTietPhieuNhap
    {
        [Key]
        public int IdChiTietPhieuNhap { get; set; }
        public int IdPhieuNhap { get; set; }
        public int IdSach { get; set; }
        public int SoLuong { get; set; }
        [Precision(12, 2)]
        public decimal GiaTien { get; set; }

        [ForeignKey("IdPhieuNhap")]
        public PhieuNhap? PhieuNhap { get; set; }
        [ForeignKey("IdSach")]
        public Sach? Sach { get; set; }
    }
}
