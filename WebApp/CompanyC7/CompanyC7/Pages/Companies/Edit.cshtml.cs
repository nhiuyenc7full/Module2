using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyC7.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompanyC7.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CompanyC7.Pages.Companies
{
    public class EditModel : PageModel
    {
        private readonly ICompanyData companyData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Company Company { set; get; }
        public IEnumerable<SelectListItem> CompanyTypes { set; get; }

        public IEnumerable<Company> Companies { get; set; }

        //[BindProperty(SupportsGet = true)]

        //[BindProperty]
        
        public EditModel(ICompanyData companyData, IHtmlHelper htmlHelper)
        {
            this.companyData = companyData;
            this.htmlHelper = htmlHelper;
        }
        public void OnGet(int companyId)
        {
            Company = companyData.GetById(companyId);
            CompanyTypes = htmlHelper.GetEnumSelectList<CompanyType>();
        }

        public IActionResult OnPost()
        {
            CompanyTypes = htmlHelper.GetEnumSelectList<CompanyType>();
            Company = companyData.Update(Company);
            //companyData.Commit();
            return RedirectToPage("./Detail");
        }
    }
}