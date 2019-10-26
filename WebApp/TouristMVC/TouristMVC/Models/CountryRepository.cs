using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristMVC.Models
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DbAppContext dbContext;

        public CountryRepository(DbAppContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Country> GetAll
        {
            get
            {
                return dbContext.Countries.OrderBy(c => c.Name);
            }
        }

        public Country Create()
        {
            throw new NotImplementedException();
        }

        public Country Delete(Country Country)
        {
            throw new NotImplementedException();
        }

        public Country GetById(int id)
        {
            var Country = dbContext.Countries.FirstOrDefault(c => c.CountryId == id);
            return Country;
        }

        public Country Update(Country Country)
        {
            throw new NotImplementedException();
        }
    }
}
