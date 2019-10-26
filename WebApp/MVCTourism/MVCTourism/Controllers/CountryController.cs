using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTourism.Models;
using MVCTourism.ViewModels;

namespace MVCTourism.Controllers
{
    public class CountryController : Controller
    {
        private readonly ITouristRepository touristRepository;
        private readonly ICountryRepository countryRepository;

        public CountryController(ITouristRepository TouristRepository, ICountryRepository CountryRepository)
        {
            this.touristRepository = TouristRepository;
            this.countryRepository = CountryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country Country)
        {
            if(ModelState.IsValid)
            {
                countryRepository.Create(Country);
                countryRepository.Commit();
                return RedirectToAction(nameof(List));
            }
            return View(Country);
        }
        public IActionResult List()
        {
            var countries = countryRepository.GetAll;
            return View(new CountryViewModel()
            {
                Countries = countries
            }); 
        }
    }
}