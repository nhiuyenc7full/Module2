using System;
using System.Collections.Generic;
using System.Text;
using TouristCore;

namespace TouristData
{
    public interface ITouristData
    {
        IEnumerable<Tourist> GetTouristByName(string name);
        Tourist GetTouristById(int Id);
        Tourist Delete(int Id);
        Tourist Update(Tourist Tourist);
        Tourist Create(Tourist Tourist);
        int Commit();
    }
}
