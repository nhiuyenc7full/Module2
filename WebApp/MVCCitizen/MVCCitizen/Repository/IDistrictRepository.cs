using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Repository
{
    public interface IDistrictRepository
    {
        IEnumerable<District> GetAll { get; }
        District GetById(int Id);
        void Add(District district);
        void Delete(District district);
        District Update(District district);
        int Commit();
    }
}
