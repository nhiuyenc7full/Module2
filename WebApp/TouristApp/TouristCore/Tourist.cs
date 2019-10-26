using System;
using System.Collections.Generic;
using System.Text;

namespace TouristCore
{
    public class Tourist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Room Room { get; set; }
    }
}
