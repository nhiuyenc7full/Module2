using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_2
{
    class StudentMark : IStudentMark
    {
        private string _fullName;
        private int _iD = 1000;
        private string _class;
        private int _semester;
        private float _averageMark;
        private static int id = 0;
        private List<int> SubjectMarkList = new List<int>();
        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public float AverageMark { get; set; }
        public string FullName { get; set; }

        public StudentMark ()
        {
            FullName = "Nhi Uyen";
            ID = ID + id;
            Class = "12b1";
            Semester = 2;
            AverageMark = 9.0f;
            SubjectMarkList = new List<int>(5);
            id++;
        }

        public StudentMark(string fullName, int id, string _class, int semester, float averageMark)
        {
            FullName = fullName;
            ID = ID + id;
            Class = _class;
            Semester = semester;
            AverageMark = averageMark;
            SubjectMarkList = new List<int>(5);
            id++;
        }

        public void Display()
        {
            Console.WriteLine($"FullName: {FullName}\n" +
                $"ID: {ID};\n" +
                $"Class: {Class};\n" + 
                $"Semester: {Semester}\n" +
                $"Average mark: {AverageMark}");
        }
    }
}
