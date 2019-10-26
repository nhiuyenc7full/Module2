using Microsoft.AspNetCore.Mvc;
using TouristMVC.Models;

namespace TouristMVC.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepository countryRepository;

        public CountryController(ICountryRepository CountryRepository)
        {
            countryRepository = CountryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}