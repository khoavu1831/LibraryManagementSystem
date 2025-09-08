using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    [Table("KhachHang")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("TenKhachHang", TypeName = "varchar(50)")]
        public string? Name { get; set; }

    }
}
