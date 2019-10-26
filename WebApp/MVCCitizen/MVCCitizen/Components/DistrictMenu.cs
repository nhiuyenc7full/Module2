using Microsoft.AspNetCore.Mvc;
using MVCCitizen.Models;
using MVCCitizen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Components
{
    public class DistrictMenu : ViewComponent
    {
        private readonly IDistrictRepository districtRepository;

        public DistrictMenu(IDistrictRepository DistrictRepository)
        {
            districtRepository = DistrictRepository;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<District> Districts = districtRepository.GetAll.OrderBy(d => d.Name);
            return View(Districts);
        }
    }
}
