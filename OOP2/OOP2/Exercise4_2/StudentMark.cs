using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_2
{
    public class StudentMark : IStudentMark
    {
        private static int id = 1;
        //static int sum = 0;
        private double averageMark;

        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public double AverageMark { get => AveCal(); set => averageMark = value; }
        public string FullName { get; set; }
        public Dictionary<string, int> SubjectMarkList { get; set; }

        public StudentMark ()
        {
            FullName = "Nhi Uyen";
            ID = ID + id;
            Class = "12b1";
            Semester = 2;
            AverageMark = 9;
            SubjectMarkList = new Dictionary<string, int>();
            id++;
        }

        public StudentMark(string fullName, string _class, int semester, Dictionary<string, int> subjectMarkList)
        {
            FullName = fullName;
            ID = ID + id;
            Class = _class;
            Semester = semester;
            SubjectMarkList = subjectMarkList;
            id++;
        }

        public double AveCal()
        {
            int sum = 0;
            foreach (var item in SubjectMarkList)
            {
                sum += item.Value;
            }
            double averageMark = (double) sum /  SubjectMarkList.Count;
            return averageMark;
        }
        
        public void Display()
        {
            Console.WriteLine($"ID: {ID}\n" +
                $"FullName: {FullName}\n" +
                $"Class: {Class}\n" + 
                $"Semester: {Semester}\n" +
                $"Average mark: {AverageMark}");
        }
    }
}
