using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TouristCore
{
    public class Tourist
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, Range(1, 100)]
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Country Country { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime BookDate { get; set; }

        public Room Room { get; set; }
    }
}
