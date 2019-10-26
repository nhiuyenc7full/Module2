using MVCTourism.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCTourism.ViewModels
{
    public class TouristViewModel
    {
        public int Id { get; set; }
        public Tourist Tourist { get; set; }
        public SelectList Countries { get; set; }
        public SelectList Tourists { get; set; }
    }
}
