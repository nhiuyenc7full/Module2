using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCTourism.Models;
using MVCTourism.Models.Tourists;
using MVCTourism.ViewModels;

namespace MVCTourism.Controllers
{
    public class TouristController : Controller
    {
        private readonly ITouristRepository touristRepository;
        private readonly ICountryRepository countryRepository;

        public TouristController(ITouristRepository TouristRepository, ICountryRepository CountryRepository)
        {
            this.touristRepository = TouristRepository;
            this.countryRepository = CountryRepository;
        }
        [HttpGet]
        public IActionResult Create()
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.CountryList = new SelectList(countryRepository.GetAll, "CountryId", "Name");
            return View(countryViewModel);
;        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tourist Tourist)
        {
            if (ModelState.IsValid)
            {
                touristRepository.Create(Tourist);
                touristRepository.Commit();
                return RedirectToAction(nameof(List));
            }
            return View();
        }
        public IActionResult List()
        {
            IEnumerable<Tourist> Tourists;
            Tourists = touristRepository.GetAll.OrderBy(t => t.Name);
            return View(new CountryViewModel()
            {
                Tourists = Tourists
            }); 
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.CountryList = new SelectList(countryRepository.GetAll, "CountryId", "Name");
            var Tourist = touristRepository.GetById(id);
            countryViewModel.Tourist = Tourist;
            return View(countryViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TouristRequest Tourist)
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.CountryList = new SelectList(countryRepository.GetAll, "CountryId", "Name");
            if (ModelState.IsValid)
            {
                var request = new Tourist()
                {
                };
                touristRepository.Update(request);
                touristRepository.Commit();
                return RedirectToAction(nameof(List));
            }
            return View(new CountryViewModel() { });
        }
    }
}