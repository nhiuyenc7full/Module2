﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTourism.Models
{
    public class Tourist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Tên du khách")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Giới tính")]
        public bool Sex { get; set; }

        public string SexString => Sex ? "Nam" : "Nữ";

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Ảnh đại diện")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Link ảnh không hợp lệ")]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"^[0]\d{8,9}$")]
        [Phone]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email không hợp lệ")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Không được để trống trường này")]
        //[Display(Name = "Khách VIP")]
        //public bool IsVip { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}