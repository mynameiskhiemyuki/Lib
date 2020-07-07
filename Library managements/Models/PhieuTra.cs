using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_managements.Models
{
    public class PhieuTra
    {
        [Key]
        public int maPhieuTra { get; set; }
        public int maPhieuMuon { get; set; }

 
        public int maSach { get; set; }

        public DateTime? ngayMuon { get; set; }
    }
}
