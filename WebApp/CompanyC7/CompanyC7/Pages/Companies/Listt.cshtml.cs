using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyC7.Data;
using CompanyC7.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CompanyC7.Pages.Companies
{
    public class ListtModel : PageModel
    {

        private readonly IConfiguration config;
        private readonly ICompanyData companyData;

        public string Message { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<Company> Companies { get; set; }

        //lúc đầu là public ListtModel(IConfiguration config)...
        //x2 sau khi tạo ICompanyData thì thêm vào public ListtModel(IConfiguration config, ICompanyData companyData)
        //Báo lỗi, thì references với Data (hoặc Ctrl+. để biết lỗi và chọn references)
        //Báo lỗi, Ctrl. để tool đọc lỗi, sửa giúp
        // thêm Companies = companyData.GetAll(); vào OnGet(); để truyền dữ liệu vào GetAll();
        public ListtModel(IConfiguration config, ICompanyData companyData) /*Ctrl.*/
        {
            this.config = config;
            this.companyData = companyData;
        }

        public void OnGet()
        {
            //Message = "We are a family!";
            //vào json, thêm một Key "Message", thêm value, để che dấu dữ liệu.
            Message = config["Message"];
            //Companies = companyData.GetAll();
            Companies = companyData.GetCompaniesByName(SearchKeyWord);

        }
    }
}