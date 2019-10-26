using System.ComponentModel.DataAnnotations;

namespace TouristMVC.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Quốc gia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Mô tae")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Ảnh đại diện")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Link ảnh không hợp lệ")]
        public string UrlImage { get; set; }
      
    }
    
}
