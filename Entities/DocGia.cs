using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("DocGia")]
    public class DocGia
    {
        [Key]
        public int IdDocGia { get; set; }
        public string? TenDocGia { get; set; }
        public string? DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public ICollection<TheThanhVien>? TheThanhViens { get; set; }
    }
}
