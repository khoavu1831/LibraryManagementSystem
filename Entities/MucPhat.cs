using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("MucPhat")]
    public class MucPhat
    {
        [Key]
        public int IdMucPhat { get; set; }
        public string? TenMucPhat { get; set; }
        [Precision(12, 2)]
        public decimal SoTienPhat { get; set; }
        public string? MoTa { get; set; }
        public LoaiPhatEnum LoaiPhat { get; set; }
        public ICollection<ChiTietPhieuPhat>? ChiTietPhieuPhats { get; set; }
        public int IsActive { get; set; } = 1;
        public enum LoaiPhatEnum
        {
            [Display(Name = "Quá hạn")]
            QuaHan,
            [Display(Name = "Làm mất")]
            LamMat,
            [Display(Name = "Làm hỏng")]
            LamHong
        }
    }
}
