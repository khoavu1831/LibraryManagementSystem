using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("PhieuMuon")]
    public class PhieuMuon
    {
        [Key]
        public int IdPhieuMuon { get; set; }
    }
}
