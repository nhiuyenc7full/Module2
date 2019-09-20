using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise4_2
{
    class Program
    {
        //public StudentRepository studentRero = new StudentRepository();
        static void Main(string[] args)
        {
            string path = "D:/FileExport/4_2";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            StudentRepository.RefreshListStudent();
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*      MARKS MANAGEMENT SYSTEM      *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Insert new student         *");
            Console.WriteLine("\t\t\t*     2. View list of students      *");
            Console.WriteLine("\t\t\t*     3. Export file                *");
            Console.WriteLine("\t\t\t*     4. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, or 4");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 4)
            {
                Console.Write("Enter again! Choose from 1 to 4! \t");
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
                    StudentRepository.CreateStudent();
                    break;
                case 2:
                    StudentRepository.ViewListStudent();
                    break;
                case 3:
                    StudentRepository.ExportFile();
                    break;
                case 4:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }

    }
}
