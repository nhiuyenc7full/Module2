using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace MVCTourism.Models
{
    public class TouristRepository : ITouristRepository
    {
        private readonly TourismDbContext context;

        public TouristRepository(TourismDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Tourist> GetAll
        {
            get
            {
                return context.Tourists.Include(t => t.Country);
            }
        }

        public void Create(Tourist tourist)
        {
            context.Tourists.Add(tourist);
        }

        public void Delete(Tourist tourist)
        {
            if (context.Entry(tourist).State == EntityState.Detached)
            {
                context.Attach(tourist);
            }
            context.Remove(tourist);
        }

        public Tourist GetById(int id)
        {
            return context.Tourists.Include(t => t.Country).FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Tourist> GetByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return context.Tourists.Include(t => t.Country);
            }
            return context.Tourists.Include(t => t.Country).Where(t => t.Name.Contains(name));
        }

        public Tourist Update(Tourist tourist)
        {
            var entity = context.Tourists.Attach(tourist);
            entity.State = EntityState.Modified;
            return tourist;
        }
        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
