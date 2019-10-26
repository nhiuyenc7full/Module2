using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristMVC.Models;

namespace TouristMVC.ViewModels
{
    public class TouristListViewModel
    {
        public IEnumerable<Tourist> Tourists { get; set; }
        public string CurrentCountry { get; set; }
    }
}
