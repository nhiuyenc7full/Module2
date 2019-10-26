using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TouristMVC.Models;

namespace TouristMVC.ViewModels
{
    public class TouristViewModel
    {
        public int CountryId { get; set; }
        public Tourist Tourist { get; set; }
        public SelectList Countryies { get; set; }
    }
}
