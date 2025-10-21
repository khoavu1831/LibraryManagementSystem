using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        public int IdTheLoai { get; set; }
        public string? TenTheloai { get; set; }
        public ICollection<Sach>? Sachs { get; set; }
    }
}
