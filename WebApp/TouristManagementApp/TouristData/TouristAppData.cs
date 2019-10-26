using System;
using System.Collections.Generic;
using System.Text;
using TouristCore;

namespace TouristData
{
    public class TouristAppData : ITouristData
    {
        private readonly TouristContext Dbcontext;

        public TouristAppData(TouristContext Dbcontext)
        {
            this.Dbcontext = Dbcontext;
        }
        public int Commit()
        {
            try
            {
                return Dbcontext.SaveChanges();
            }
            catch(System.Exception)
            {
                return 0;
            }
        }

        public Tourist Create(Tourist Tourist)
        {
            Dbcontext.Add(Tourist);
            return Tourist;
        }

        public Tourist Delete(int Id)
        {
            Tourist Tourist = GetTouristById(Id);
            Dbcontext.Remove(Tourist);
            return Tourist;
        }

        public Tourist GetTouristById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tourist> GetTouristByName(string name)
        {
            throw new NotImplementedException();
        }

        public Tourist Update(Tourist Tourist)
        {
            throw new NotImplementedException();
        }
    }
}
