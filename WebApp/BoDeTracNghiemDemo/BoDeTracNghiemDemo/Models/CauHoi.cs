using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Models
{
    public class CauHoi
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        public string CauTraLoi1 { get; set; }
        public string CauTraLoi2 { get; set; }
        public string CauTraLoi3 { get; set; }
        public string CauTraLoi4 { get; set; }
        public DapAn DapAn { get; set; }
        public int TheLoaiId { get; set; }
        public TheLoai TheLoai { get; set; }
        public List<CauHoiThi> CauHoiThis { get; set; }
    }
}
