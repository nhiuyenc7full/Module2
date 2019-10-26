using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentCore
{
    public class Student
    {
        public int Id { get; set; }
        [Required, StringLength(5)]
        public string Name { get; set; }
        [Required, StringLength(250)]
        public string Address { get; set; }
        public Sport Sport { get; set; }

    }
}
