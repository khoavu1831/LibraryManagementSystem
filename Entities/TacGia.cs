using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("TacGia")]
    public class TacGia
    {
        [Key]
        public int IdTacGia { get; set; }
        public string? TenTacGia { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? NoiSinh { get; set; }
        public string? SDT { get; set; }
        public ICollection<Sach>? Sachs { get; set; }
    }
}
