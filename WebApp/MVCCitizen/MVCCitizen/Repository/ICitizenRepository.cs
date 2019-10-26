using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Repository
{
    public interface ICitizenRepository
    {
        IEnumerable<Citizen> GetAll { get; }
        Citizen GetById(int Id);
        void Add(Citizen citizen);
        void Delete(Citizen citizen);
        Citizen Update(Citizen citizen);
        int Commit();
    }
}
