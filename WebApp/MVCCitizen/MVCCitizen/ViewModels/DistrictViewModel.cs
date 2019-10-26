using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.ViewModels
{
    public class DistrictViewModel
    {
        public District District { get; set; }
        public SelectList Provinces { get; set; }
    }
}
