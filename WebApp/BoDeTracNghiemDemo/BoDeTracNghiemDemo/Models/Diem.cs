using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class Diem
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        public int ThiId { get; set; }
        public Thi Thi { get; set; }
    }
}
