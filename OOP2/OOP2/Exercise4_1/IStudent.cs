using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_1
{
    interface IStudent
    {
        string FullName { get; set; }
        DateTime DateofBirth { get; set; }
        int ID { get; set; }
        string Native { get; set; }
        string Class { get; set; }
        int PhoneNo { get; set; }
        string Mobile { get; set; }

        void Display();

    }
}
