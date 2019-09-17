using System;
using System.Collections;

namespace Exercise4_1
{
    class Program
    {
        public static Hashtable studentList = new Hashtable();
        static Student student;
        static void Main(string[] args)
        {
            Console.WriteLine("");
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*     STUDENTS MANAGEMENT SYSTEM    *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Insert new student         *");
            Console.WriteLine("\t\t\t*     2. View list of students      *");
            Console.WriteLine("\t\t\t*     3. Search students            *");
            Console.WriteLine("\t\t\t*     4. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3 or 4");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 4)
            {
                Console.WriteLine("Enter again! Choose 1, 2, 3 or 4! ");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }

        static void ChooseMenu(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    CreateStudent();
                    break;
                case 2:
                    ViewStudentList();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }
        static void CreateStudent()
        {
            Console.Write("Enter the full name of student: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter the date of birth of student: ");
            DateTime dateofBirth;
            string str = Console.ReadLine();
            while (!DateTime.TryParse(str, out dateofBirth))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            String.Format("{0:d}", dateofBirth);
            Console.Write("Enter the native of student: ");
            string native = Console.ReadLine();
            Console.Write("Enter the class of student: ");
            string _class = Console.ReadLine();
            Console.Write("Enter the phone number of student: ");
            str = Console.ReadLine();
            int phoneNo;
            while (!int.TryParse(str, out phoneNo))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter the mobile of student: ");
            string mobile = Console.ReadLine();
            student = new Student(fullName,  dateofBirth,  native,  _class,  phoneNo,  mobile);
            studentList.Add(student.ID, student);
            Console.WriteLine("\nThis student was added.\n");
            student.Display();
        }

        static void ViewStudentList()
        {
            foreach (Student item in studentList.Values)
            {
                item.Display();
            }
        }

        static void SearchStudent()
        {
            Console.WriteLine("What class do you want to search?");
            string str = Console.ReadLine();
            Console.WriteLine("Your search is done: ");
            foreach (Student item in studentList.Values)
            {
                if (item.Class.Equals(str))
                {
                    item.Display();
                    Console.WriteLine();
                }

            }
        }
    }
}
