using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristMVC.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll { get; }
        Country GetById(int id);
        Country Create();
        Country Update(Country Country);
        Country Delete(Country Country);
    }
}
