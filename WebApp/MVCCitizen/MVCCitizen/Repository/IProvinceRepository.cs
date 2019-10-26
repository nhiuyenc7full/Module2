using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Repository
{
    public interface IProvinceRepository
    {
        IEnumerable<Province> GetAll { get; }
        Province GetById(int Id);
        void Add(Province province);
        void Delete(Province province);
        Province Update(Province province);
        int Commit();
    }
}
