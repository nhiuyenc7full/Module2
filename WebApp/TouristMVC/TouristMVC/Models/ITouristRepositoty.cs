using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace TouristMVC.Models
{ 
    public interface ITouristRepository
    {
        IEnumerable<Tourist> GetAll { get; }
        Tourist GetById(int id);
        void Add(Tourist Tourist);
        void Delete(int TouristId);
        void Commit();
        Tourist Update(Tourist Tourist);
    }
}
