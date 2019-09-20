using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise4_2
{
    public class StudentRepository
    {

        public static List<StudentMark> studentList = new List<StudentMark>();
        public static string path = "D:/FileExport/4_2/";
        public static void CreateStudent()
        {
            Console.Write("Enter full name: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter class: ");
            string _class = Console.ReadLine();
            Console.Write("Enter semester: ");
            string str = Console.ReadLine();
            int semester;
            while (!int.TryParse(str, out semester) || semester < 1 || semester > 10)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Dictionary<string, int> SubjectMarkList = EnterMark();
            StudentMark student = new StudentMark(fullname, _class, semester, SubjectMarkList);
            studentList.Add(student);
            Console.WriteLine("\n\t" + fullname + " is added to the list...\n");
        }

        public static void ViewListStudent()
        {
            foreach (var item in studentList)
            {
                Console.WriteLine($"Student {item.ID}:");
                item.Display();
                Console.WriteLine();
            }
        }

        public static void ExportFile()
        {
            foreach (var item in studentList)
            {
                using (StreamWriter sw = new StreamWriter(path + item.ID + ".txt"))
                {
                    sw.WriteLine("ID: " + item.ID);
                    sw.WriteLine("Full Name: " + item.FullName);
                    sw.WriteLine("Class: " + item.Class);
                    sw.WriteLine("Semester: " + item.Semester);
                    sw.WriteLine("Average Mark: " + item.AverageMark);
                }
            }
            Console.WriteLine("File is exported...");
        }

        public static void RefreshListStudent()
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.txt");
            for (int i = 0; i < files.Length; i++)
            {
                StudentMark student = new StudentMark();
                string path = files[i].FullName;
                string[] lines = File.ReadAllLines(path);
                using (StreamReader sr = new StreamReader(path))
                {
                    int indexOfValue = lines[0].IndexOf(": ") + 2;
                    student.ID = int.Parse(lines[0].Substring(indexOfValue).Trim());
                    indexOfValue = lines[1].IndexOf(": ") + 2;
                    student.FullName = lines[1].Substring(indexOfValue).Trim();
                    indexOfValue = lines[2].IndexOf(": ") + 2;
                    student.Class = lines[2].Substring(indexOfValue).Trim();
                    indexOfValue = lines[3].IndexOf(": ") + 2;
                    student.Semester = int.Parse(lines[3].Substring(indexOfValue).Trim());
                    indexOfValue = lines[4].IndexOf(": ") + 2;
                    student.AverageMark = (double) double.Parse(lines[4].Substring(indexOfValue, 3).Trim());
                   
                }
                studentList.Add(student);
            }
        }
        public static Dictionary<string, int> EnterMark()
        {
            Dictionary<string, int> SubjectMarkList = new Dictionary<string, int>();
            Console.WriteLine("Enter Subject and Mark: ");
            string str = String.Empty;
            do
            {
                Console.Write("Enter Subject: \t");
                string subject = Console.ReadLine();
                Console.Write("Enter Mark: \t");
                int mark = CheckIntVal(Console.ReadLine());
                SubjectMarkList.Add(subject, mark);
                Console.Write("Do you want to enter new Subject-Mark? press 'ok' to accept, press any keyboard to cancel.");
                str = Console.ReadLine();
            }
            while (str.Equals("ok"));

            return SubjectMarkList;
        }

        public static int CheckIntVal(string str)
        {
            int num;
            while (!int.TryParse(str, out num) || num < 1 || num > 10)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return num;
        }
    }
}
