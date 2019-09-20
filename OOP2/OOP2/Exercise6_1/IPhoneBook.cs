using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6_1
{
    interface IPhoneBook
    {

        string Name { get; set; }
        int Phone { get; set; }

        void InsertPhone(string Name, int Phone);
        void RemovePhone(string Name);
        void UpdatePhone(string Name, int Newphone);
        void SearchPhone(string Name);
        void Sort();

    }
}
