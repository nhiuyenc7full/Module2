using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTourism.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll { get; }
        void Create(Country Country);
        void Commit();
    }
}
