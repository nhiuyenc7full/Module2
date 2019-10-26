using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        public List<CauHoi> CauHois { get; set; }
    }
}
