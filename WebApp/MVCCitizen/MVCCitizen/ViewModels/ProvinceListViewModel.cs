using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.ViewModels
{
    public class ProvinceListViewModel
    {
        public IEnumerable<Province> Provinces { get; set; }
        public Province Province { get; set; }
    }
}
