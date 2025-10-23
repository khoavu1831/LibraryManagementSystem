using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int IdNhanVien { get; set; }
        public int IdTaiKhoan { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }

        [ForeignKey("IdTaiKhoan")]
        public TaiKhoan? TaiKhoan { get; set; }
        public ICollection<PhieuMuon>? PhieuMuons { get; set; }
        public ICollection<PhieuNhap>? PhieuNhaps { get; set; }
    }
}
