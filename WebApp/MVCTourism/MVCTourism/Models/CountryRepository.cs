using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTourism.Models
{
    public class CountryRepository : ICountryRepository
    {
        private readonly TourismDbContext context;

        public CountryRepository(TourismDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Country> GetAll
        {
            get
            {
                return context.Countries.OrderBy(c => c.Name);
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Create(Country Country)
        {
            context.Countries.Add(Country);
        }
    }
}
