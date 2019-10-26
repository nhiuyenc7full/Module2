using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCitizen.Models;

namespace MVCCitizen.Repository
{
    public class DistrictRepository : IDistrictRepository
    {
        private readonly AppDbContext context;

        public DistrictRepository(AppDbContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<District> GetAll 
        { 
            get 
            {
                return context.Districts.Include(d => d.Province);
            } 
        }

        public void Add(District district)
        {
            context.Add(district);
        }

        public int Commit()
        {
            try
            {
                return context.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }

        public void Delete(District district)
        {
            context.Remove(district);
        }

        public District GetById(int Id)
        {
            return context.Districts.Include(d => d.Citizens).FirstOrDefault(d => d.Id == Id);
        }

        public District Update(District district)
        {
            context.Update(district);
            return district;
        }
    }
}
