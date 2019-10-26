using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTourism.Models
{
    public interface ITouristRepository
    {
        IEnumerable<Tourist> GetAll { get; }
        Tourist GetById(int id);
        IEnumerable<Tourist> GetByName(string name);
        void Create(Tourist tourist);
        void Delete(Tourist tourist);
        Tourist Update(Tourist tourist);
        void Commit();
    }
}
