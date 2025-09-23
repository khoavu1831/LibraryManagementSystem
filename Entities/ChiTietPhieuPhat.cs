using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    [Table("ChiTietPhieuPhat")]
    public class ChiTietPhieuPhat
    {
        [Key]
        public int IdChiTietPhieuPhat { get; set; }
        public int IdPhieuPhat { get; set; }
        public int IdChiTietPhieuMuon { get; set; }
        public int IdMucPhat { get; set; }
        public int SoNgayTreHen { get; set; }
        [Precision(12, 2)]
        public decimal TienPhatTra { get; set; }

        [ForeignKey("IdPhieuPhat")]
        public PhieuPhat? PhieuPhat { get; set; }

        [ForeignKey("IdChiTietPhieuMuon")]
        public ChiTietPhieuMuon? ChiTietPhieuMuon { get; set; }

        [ForeignKey("IdMucPhat")]
        public MucPhat? MucPhat { get; set; }
    }
}
