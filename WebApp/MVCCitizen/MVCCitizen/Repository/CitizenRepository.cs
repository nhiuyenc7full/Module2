using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCitizen.Models;

namespace MVCCitizen.Repository
{
    public class CitizenRepository : ICitizenRepository
    {
        private readonly AppDbContext context;

        public CitizenRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Citizen> GetAll 
        {
            get
            {
                return context.Citizens;
            }
        }

        public void Add(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public Citizen GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Citizen Update(Citizen citizen)
        {
            throw new NotImplementedException();
        }
    }
}
