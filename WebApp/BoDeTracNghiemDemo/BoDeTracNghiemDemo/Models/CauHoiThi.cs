using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Models
{
    public class CauHoiThi
    {
        public int CauHoiId { get; set; }
        public int ThiId { get; set; }
        [Required]
        public string Ten { get; set; }
        public Thi Thi { get; set; }
        public CauHoi CauHoi { get; set; }
    }
}
