using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTourism.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Quốc gia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Thủ đô")]
        public string Capital { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Ảnh đại diện")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Link ảnh không hợp lệ")]
        public string UrlImage { get; set; }
    }
}
