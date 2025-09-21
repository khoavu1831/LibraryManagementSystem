using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("SanPham")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("TenSanPham", TypeName = "varchar(50)")]
        public string? Name { get; set; }

    }
}
