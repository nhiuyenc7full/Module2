using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class DapAn
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        //public string LuaChon { get; set; }
        public CauHoi CauHoi { get; set; }
        public int CauHoiId { get; set; }
    }
}
