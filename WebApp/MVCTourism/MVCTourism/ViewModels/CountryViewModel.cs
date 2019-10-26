using Microsoft.AspNetCore.Mvc.Rendering;
using MVCTourism.Models;
using System.Collections.Generic;

namespace MVCTourism.ViewModels
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public SelectList CountryList { get; set; }
        public IEnumerable<Tourist> Tourists { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public Tourist Tourist { get; set; }
    }
}
