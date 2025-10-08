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
    [Table("PhieuNhap")]
    public class PhieuNhap
    {
        [Key]
        public int IdPhieuNhap { get; set; }
        public int IdNCC { get; set; }
        public int IdNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuongSach { get; set; }
        [Precision(12, 2)]
        public decimal TongTienNhap { get; set; }
        public LoaiPhieuNhapEnum LoaiPhieuNhap { get; set; }

        [ForeignKey("IdNCC")]
        public NCC? NCC { get; set; }
        [ForeignKey("IdNhanVien")]
        public NhanVien? NhanVien { get; set; }
        public ICollection<ChiTietPhieuNhap>? ChiTietPhieuNhaps { get; set; }
        public enum LoaiPhieuNhapEnum
        {
            Mua,
            Tang
        }
    }
}
