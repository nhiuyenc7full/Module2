using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.ViewModels
{
    public class CitizenListViewModel
    {
        public IEnumerable<Citizen> Citizens { get; set; }
        public string CurrentDistrict { get; set; }
    }
}
