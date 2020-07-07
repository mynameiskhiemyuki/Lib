using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_managements.Models
{
    public class DocGia
    {
        [Key]
        public int maDocGia { get; set; }
        [Display(Name = "Tên")]
        public string tenDocGia { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime? ngaySinh { get; set; }
        [Display(Name = "Địa chỉ")]
        public string diaChi { get; set; }
        [Display(Name = "Di động")]
        public string dienThoai { get; set; }

    }
}
