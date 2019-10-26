using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public class Employee
    {
        [Display(Name = "Mã nhân viên")]
        public int Id { get; set; }
        public int GroupId { get; set; }
        [Display(Name = "Chọn nhóm nhân viên")]
        public Group Group { get; set; }
        [Display(Name = "Tên nhân viên")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ngày sinh")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Giới tính")]
        [Required]
        public bool Sex { get; set; }
        //public string SexString => Sex ? "Nam" : "Nữ";
        [Display(Name = "Số điện thoại")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string Tel { get; set; }
        [Display(Name = "Số CMND")]
        [Required]
        [RegularExpression(@"^\d{9}$")]
        public string CMND { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required]
        public string Address { get; set; }
    }
}
