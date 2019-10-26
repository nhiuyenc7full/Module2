using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Models
{
    public class Thi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ten { get; set; }
        public int CauHoiThiId { get; set; }
        public List<CauHoiThi> CauHoiThis { get; set; }
        public Diem Diem { get; set; }
        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}
