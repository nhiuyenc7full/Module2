using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.ViewModels
{
    public class DistrictListViewModel
    {
        //public District District { get; set; }
        public IEnumerable<District> Districts { get; set; }
        public string CurrentProvince { get; set; }
    }
}
