using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public int IdTaiKhoan { get; set; }
        public int IdVaiTro { get; set; }
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }

        [ForeignKey("IdVaiTro")]
        public VaiTro? VaiTro { get; set; }
        public ICollection<NhanVien>? NhanViens { get; set; }
    }
}
