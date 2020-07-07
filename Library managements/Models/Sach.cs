using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_managements.Models
{
    public class Sach
    {
        [Key]
        public int maSach { get; set; }

        [Display(Name = "Tên sách")]
        public string tenSach { get; set; }
        [Display(Name = "Tác giả")]
        public string tacGia { get; set; }
        [Display(Name = "Tóm tắt")]
        public string tomTat { get; set; }
        [Display(Name = "Tình trạng")]
        public string tinhTrang { get; set; }
    }
}
