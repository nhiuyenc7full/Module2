using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required, Display(Name="Tên huyện/ thành phố")]
        public string Name { get; set; }
        [Required, Display(Name = "Mô tả")]
        public string Description { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public List<Citizen> Citizens { get; set; }
    }
}
