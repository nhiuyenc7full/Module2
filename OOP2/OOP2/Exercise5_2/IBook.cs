using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5_2
{
    interface IBook
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Language { get; set; }
        float AveragePrice { get; }

        void Display();
    }
}
