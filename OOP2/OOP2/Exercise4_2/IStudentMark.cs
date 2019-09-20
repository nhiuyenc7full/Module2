using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_2
{
    interface IStudentMark
    {
        string FullName { get; set; }
        int ID { get; set; }
        string Class { get; set; }
        int Semester { get; set; }
        double AverageMark { get; set; }

        void Display();
    }
}
