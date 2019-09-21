using System;
using System.Collections.Generic;
using System.Text;

namespace Practice7_1
{
    interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string Password { get; set; }

        //int? this[int index] { get; set; }

        void Display();
    }
}
