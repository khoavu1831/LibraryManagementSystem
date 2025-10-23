using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("NXB")]
    public class NXB
    {
        [Key]
        public int IdNXB { get; set; }
        public string? TenNXB { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public ICollection<Sach>? Sachs { get; set; }
    }
}
