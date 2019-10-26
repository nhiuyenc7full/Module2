using System;
using System.Collections.Generic;
using CompanyC7.Core;
using System.Linq;

namespace CompanyC7.Data
{
    public class InMemoryCompanyData : ICompanyData
    {
        //public Company Company { set; get; }
        public List<Company> companies { get; set; }
        public InMemoryCompanyData()
        {
            companies = new List<Company>()
            {
                new Company {Id = 1, Name = "CodeGym", Location = "28 Nguyễn Tri Phương", CompanyType = CompanyType.CNTT},
                new Company {Id = 2, Name = "3S", Location = "28 Nguyễn Tri Phương", CompanyType = CompanyType.Hotgirl},
                new Company {Id = 3, Name = "DeHa", Location = "28 Nguyễn Tri Phương", CompanyType = CompanyType.SaleHeadHuman}
            };
        }

        public IEnumerable<Company> GetCompaniesByName(string name) // nếu không truyền null thì mặc định vẫn là null
        {
            //thêm vào nếu báo lỗi thì thêm using linq
            if (name == null)
            {
                //return RedirectToPage("./NotFound");
            }
            return from c in companies
                   where string.IsNullOrEmpty(name) || c.Name.StartsWith(name)
                   orderby c.Name
                   select c;
        }
        public Company GetById(int companyId)
        {
            return companies.SingleOrDefault(c => c.Id == companyId);

        }

        public Company Update(Company newCompany)
        {
            var company = companies.FirstOrDefault(c => c.Id == newCompany.Id);
            if (company != null)
            {
                company.Name = newCompany.Name;
                company.Location = newCompany.Location;
                company.CompanyType = newCompany.CompanyType;
                return company;
            }
            return company;
        }
        //    public IEnumerable<Company> GetAll()
        //    {
        //        return from c in companies
        //               select c;
        //    }
        //    //public IEnumerable<Company> Delete(int companyId)
        //    //{
        //    //    return from c in companies
        //    //           where c.Id == companyId
        //    //           select c;
        //    //}
        //    public Company Delete(int companyId)
        //    {
        //        var company = companies.FirstOrDefault(c => c.Id == companyId);
        //        if(company != null)
        //        {
        //            companies.Remove(company);
        //        }
        //        return company;
        //    }
        //    public int Commit()
        //    {
        //        return 0;
        //    }

        //    IEnumerable<Company> ICompanyData.GetCompaniesByName(string name)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    Company ICompanyData.GetById(int companyId)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    Company ICompanyData.Update(Company newCompany)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    IEnumerable<Company> ICompanyData.GetAll()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    Company ICompanyData.Delete(int companyId)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    int ICompanyData.Commit()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    Company ICompanyData.Add(Company newCompany)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
