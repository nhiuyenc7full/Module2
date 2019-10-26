using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TouristMVC.Models;

namespace TouristMVC.Components
{
    public class CountryMenu : ViewComponent
    {
        private readonly ICountryRepository countryRepository;

        public CountryMenu(ICountryRepository CountryRepository)
        {
            this.countryRepository = CountryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var Countries = countryRepository.GetAll.OrderBy(c => c.Name);
            return View(Countries);
        }
    }
}
