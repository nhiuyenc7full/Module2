using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Models
{
    public class Province
    {
        public int Id { get; set; }
        [Required, Display(Name="Tên tỉnh")]
        public string Name { get; set; }
        [Required, Display(Name="Mô tả")]
        public string Description { get; set; }
        public List<District> Districts { get; set; }

    }
}
