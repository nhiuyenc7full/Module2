using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCitizen.Models;
using MVCCitizen.Repository;
using MVCCitizen.ViewModels;

namespace MVCCitizen.Controllers
{
    public class DistrictsController : Controller
    {
        private readonly IDistrictRepository districtRepository;
        private readonly IProvinceRepository provinceRepository;

        public DistrictsController(IDistrictRepository DistrictRepository, IProvinceRepository provinceRepository)
        {
            this.districtRepository = DistrictRepository;
            this.provinceRepository = provinceRepository;
        }
        // GET: Districts
        public IActionResult Index(string ProvinceName)
        {

            IEnumerable<District> Districts;
            string CurrentProvince;

            if (string.IsNullOrEmpty(ProvinceName))
            {
                Districts = districtRepository.GetAll.OrderBy(t => t.Name);
                CurrentProvince = "All provinces";
            }
            else
            {
                Districts = districtRepository.GetAll.Where(t => t.Province.Name == ProvinceName).OrderBy(t => t.Name);
                CurrentProvince = ProvinceName;
            }

            return View(new DistrictListViewModel
            {
                Districts = Districts,
                CurrentProvince = CurrentProvince
            });
        }

        //GET: Districts/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = districtRepository.GetAll.FirstOrDefault(m => m.Id == id);
            if (district == null)
            {
                return NotFound();
            }

            return View(district);
        }

        public IActionResult Create()
        {
            DistrictViewModel districtViewModel = new DistrictViewModel();
            districtViewModel.Provinces = new SelectList(provinceRepository.GetAll, "Id", "Name");

            return View(districtViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Description,ProvinceId")] District district)
        {
            if (ModelState.IsValid)
            {
                districtRepository.Add(district);
                districtRepository.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(district);
        }

        // GET: Districts/Edit/5
        public IActionResult Edit(int? id)
        {
            DistrictViewModel districtViewModel = new DistrictViewModel();
            districtViewModel.Provinces = new SelectList(provinceRepository.GetAll, "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }

            districtViewModel.District = districtRepository.GetAll.FirstOrDefault(d => d.Id == id);
            if (districtViewModel.District == null)
            {
                return NotFound();
            }
            return View(districtViewModel);
        }

        // POST: Districts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Description,ProvinceId")] District district)
        {
            DistrictViewModel districtViewModel = new DistrictViewModel();
            districtViewModel.Provinces = new SelectList(provinceRepository.GetAll, "Id", "Name");
            districtViewModel.District = district;
            if (id != district.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    districtRepository.Update(district);
                    districtRepository.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistrictExists(district.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Districts/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = districtRepository.GetAll
                .FirstOrDefault(m => m.Id == id);
            if (district == null)
            {
                return NotFound();
            }

            return View(district);
        }

        // POST: Districts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var district = districtRepository.GetAll.FirstOrDefault(d => d.Id == id);
            districtRepository.Delete(district);
            districtRepository.Commit();
            return RedirectToAction(nameof(Index));
        }

        private bool DistrictExists(int id)
        {
            return districtRepository.GetAll.Any(e => e.Id == id);
        }
    }
}
