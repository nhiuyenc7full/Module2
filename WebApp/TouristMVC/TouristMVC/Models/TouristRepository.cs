using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristMVC.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TouristMVC.Models
{
    public class TouristRepository : ITouristRepository
    {
        private readonly DbAppContext dbContext;

        public TouristRepository(DbAppContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Tourist> GetAll
        {
            get
            {
                return dbContext.Tourists.Include(g => g.Country);
            }
        }

        public void Add(Tourist Tourist)
        {
            dbContext.Add(Tourist);
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
        public void Delete(int TouristId)
        {
            var Tourist = dbContext.Tourists.FirstOrDefault(t => t.Id == TouristId);
            dbContext.Remove(Tourist);
        }

        public Tourist GetById(int id)
        {
            return dbContext.Tourists.Include(g => g.Country).FirstOrDefault(t => t.Id == id);
        }
        public Tourist Update(Tourist Tourist)
        {
            //var entity = dbContext.Tourists.Attach(Tourist);
            var entity = dbContext.Tourists.Update(Tourist);
            entity.State = EntityState.Modified;
            return Tourist;
        }
    }
}
