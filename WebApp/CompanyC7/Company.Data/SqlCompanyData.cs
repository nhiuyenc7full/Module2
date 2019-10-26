using System.Collections.Generic;
using CompanyC7.Core;
using System.Linq;

namespace CompanyC7.Data
{
    public class SqlCompanyData : ICompanyData
    {
        private readonly CompanyAppDbContext dbContext;

        public SqlCompanyData(CompanyAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Company Add(Company newCompany)
        {
            dbContext.Add(newCompany);
            return newCompany;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public Company Delete(int companyId)
        {
            var company = GetById(companyId);
            if(company != null)
            {
                dbContext.Companies.Remove(company);
            }
            return company;
        }

        public IEnumerable<Company> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Company GetById(int companyId)
        {
            return dbContext.Companies.Find(companyId);
        }

        public IEnumerable<Company> GetCompaniesByName(string name)
        {
            var result = from c in dbContext.Companies
                         where string.IsNullOrEmpty(name) || c.Name.StartsWith(name)
                         select c;
            return result;
        }

        public Company Update(Company updateCompany)
        {
            var entity = dbContext.Companies.Attach(updateCompany);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updateCompany;
        }
    }

}
