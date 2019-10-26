using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Models
{
    public class Citizen
    {
        public int Id { get; set; }
        [Required, Display(Name="Tên")]
        public string Name { get; set; }
        [Required, DataType(DataType.PhoneNumber), Display(Name="Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required, DataType(DataType.Date), Display(Name="Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        //public string GenderString => Gender ? "Nam" : "Nữ";
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
