using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyC7.Data;
using CompanyC7.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyC7.Pages.Companies
{
    public class DetailModel : PageModel
    {
        private readonly ICompanyData companyData;
        public Company Company { get; set; }
        public DetailModel(ICompanyData companyData)
        {
            this.companyData = companyData;
        }
        public IActionResult OnGet(int companyId)
        {
            Company = companyData.GetById(companyId);
            if (Company == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}