using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyC7.Core;
using CompanyC7.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyC7.Pages.Companies
{
    public class DeleteModel : PageModel
    {
        private ICompanyData companyData;
        public Company Company { get; set; }
        public IEnumerable<Company> Companies { get; set; }

        public DeleteModel(ICompanyData companyData)
        {
            this.companyData = companyData;
            //this.Companies = companyData.GetAll();
        }
        //public void OnGet(int companyId)
        //{
        //    Company = companyData.Delete(companyId);
        //}
        //public void OnPost()
        //{
        //    Companies = companyData.GetAll();

        //}
    }
}