using Microsoft.AspNetCore.Mvc;
using MVCCitizen.Models;
using MVCCitizen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Components
{
    public class ProvinceMenu : ViewComponent
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceMenu(IProvinceRepository ProvinceRepository)
        {
            this.provinceRepository = ProvinceRepository;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<Province> provinces = provinceRepository.GetAll.OrderBy(p => p.Name);
            return View(provinces);
        }
    }
}
