using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TouristMVC.Models;
using TouristMVC.ViewModels;

namespace TouristMVC.Controllers
{
    public class TouristController : Controller
    {
        private readonly ITouristRepository touristRepository;
        private readonly ICountryRepository countryRepository;
        private readonly DbAppContext context;

        public TouristController(ITouristRepository TouristRepository, ICountryRepository CountryRepository, DbAppContext context)
        {
            this.touristRepository = TouristRepository;
            this.countryRepository = CountryRepository;
            this.context = context;
        }
        public IActionResult List(string CountryName)
        {
            IEnumerable<Tourist> Tourists;
            string CurrentCountry;

            if(string.IsNullOrEmpty(CountryName))
            {
                Tourists = touristRepository.GetAll.OrderBy(t => t.Name);
                CurrentCountry = "All Country";
            }
            else
            {
                Tourists = touristRepository.GetAll.Where(t => t.Country.Name == CountryName).OrderBy(t => t.Name);
                CurrentCountry = countryRepository.GetAll.FirstOrDefault(c => c.Name == CountryName).Name;
            }

            return View(new TouristListViewModel
            {
                Tourists = Tourists,
                CurrentCountry = CurrentCountry
            });
        }
        public IActionResult Details(int Id) 
        {
            var Tourist = touristRepository.GetById(Id);
            if (Tourist == null)
            {
                return NotFound();
            }
            return View(Tourist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var touristViewModel = new TouristViewModel();
            touristViewModel.Countryies = new SelectList(countryRepository.GetAll, "CountryId", "Name");
            return View(touristViewModel);
        }
        [HttpPost]
        public IActionResult Create(Tourist Tourist)
        {
            //if (Tourist == null)
            //{
            //    return View();
            //}
            if (ModelState.IsValid)
            {
                touristRepository.Add(Tourist);
                touristRepository.Commit();
                return RedirectToAction(nameof(List));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var touristViewModel = new TouristViewModel();
            touristViewModel.Tourist = touristRepository.GetById(Id);
            touristViewModel.Countryies = new SelectList(countryRepository.GetAll, "CountryId", "Name");
            if (touristViewModel.Tourist == null)
            {
                return NotFound();
            }
            return View(touristViewModel);
        }
        [HttpPost]
        public IActionResult Edit(Tourist Tourist)
        {
            if(ModelState.IsValid)
            {
                //context.Entry(Tourist).State = EntityState.Modified;
                //context.SaveChanges();
                touristRepository.Update(Tourist);
                touristRepository.Commit();
                return RedirectToAction(nameof(List));
            }
            return View(Tourist);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            touristRepository.Delete(Id);
            touristRepository.Commit();
            return RedirectToAction(nameof(List));
        }
    }
}