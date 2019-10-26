using Microsoft.EntityFrameworkCore;
using MVCCitizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCitizen.Repository
{
    public class ProvinceRepository : IProvinceRepository
    {
            private readonly AppDbContext context;

            public ProvinceRepository(AppDbContext _context)
            {
                this.context = _context;
            }
            public IEnumerable<Province> GetAll
            {
                get
                {
                    return context.Provinces;
                }
            }

            public void Add(Province province)
            {
                context.Add(province);
            }

            public int Commit()
            {
                try
                {
                    return context.SaveChanges();
                }
                catch(System.Exception)
                {
                    return 0;
                }
            }

            public void Delete(Province province)
            {
                context.Remove(province);
            }

            public Province GetById(int Id)
            {
                return context.Provinces.Include(d => d.Districts).FirstOrDefault(d => d.Id == Id);
            }

            public Province Update(Province province)
            {
                context.Update(province);
                return province;
            }
        }
}
