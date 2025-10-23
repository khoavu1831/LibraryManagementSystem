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
    [Table("PhieuPhat")]
    public class PhieuPhat
    {
        [Key]
        public int IdPhieuPhat { get; set; }
        public DateTime NgayLap { get; set; }
        [Precision(12, 2)]
        public decimal TienPhatPhaiNop { get; set; }
        public string? LyDoPhat { get; set; }
        public TrangThaiEnum TrangThai { get; set; }
        public ICollection<ChiTietPhieuPhat>? ChiTietPhieuPhats { get; set; }
        public enum TrangThaiEnum
        {
            [Display(Name = "Chưa thu")]
            ChuaThu,
            [Display(Name = "Đã thu")]
            DaThu,
            [Display(Name = "Đã hủy")]
            DaHuy
        }
    }
}
