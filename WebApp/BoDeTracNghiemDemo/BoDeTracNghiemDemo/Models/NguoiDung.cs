using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Models
{
    public class NguoiDung
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ten { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Required]
        public string DiaChi { get; set; }
        public List<Thi> This { get; set; }
    }
}
