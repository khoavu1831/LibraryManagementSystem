using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("VaiTro")]
    public class VaiTro
    {
        [Key]
        public int IdVaiTro { get; set; }
        public string? TenVaiTro { get; set; }
        public ICollection<TaiKhoan>? TaiKhoans { get; set; }
        public ICollection<Quyen>? Quyens { get; set; } = new List<Quyen>();
    }
}
