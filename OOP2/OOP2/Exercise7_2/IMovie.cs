using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_2
{
    interface IMovie
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Director { get; set; }
        string Language { get; set; }
        float AverageRate { get; }

        void Display();
    }
}
