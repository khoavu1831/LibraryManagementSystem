using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("NCC")]
    public class NCC
    {
        [Key]
        public int IdNCC { get; set; }
        public string? TenNCC { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public ICollection<PhieuNhap>? PhieuNhaps { get; set; }
    }
}
