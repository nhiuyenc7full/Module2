using System;
using System.Collections.Generic;
using BorrowBook;
using Library;

public class Program
{
    static List<Student> studentList = new List<Student>();
    static StudentRepository studentRepo = new StudentRepository();
    static BookRepository bookRepo = new BookRepository();
    static void Main(string[] args)
    {
        bookRepo.EnterBookLibrary();
        DisplayMenu();

    }
    public static void DisplayMenu()
    {
        Console.WriteLine("\n\t\t\t*************************************");
        Console.WriteLine("\t\t\t*    PHONEBOOK MANAGEMENT SYSTEM    *");
        Console.WriteLine("\t\t\t*                                   *");
        Console.WriteLine("\t\t\t*     1. Create student             *");
        Console.WriteLine("\t\t\t*     2. Edit student infor         *");
        Console.WriteLine("\t\t\t*     3. Show list info student     *");
        Console.WriteLine("\t\t\t*     4. Exit                       *");
        Console.WriteLine("\t\t\t************************************* \n");

        Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, 4, 5 or 6");
        string str = Console.ReadLine();
        int choose;
        while (!int.TryParse(str, out choose) || choose < 0 || choose > 6)
        {
            Console.Write("Enter again! Choose from 1 to 6! \t");
            str = Console.ReadLine();
        }
        ChooseMenu(choose);
    }

    public static void ChooseMenu(int choose)
    {
        Console.Clear();
        switch (choose)
        {
            case 1:
                Student student = new Student();
                Console.WriteLine("Enter student detail info: ");
                student.CreateStudentInfo();
                studentList.Add(student);
                Console.Clear();
                bookRepo.DisplayMenuBook(student);

                break;
            case 2:
                Console.WriteLine("Enter ID of student you want to edit: ");
                string str = Console.ReadLine();
                int id;
                while(!int.TryParse(str, out id) || id < 1)
                {
                    Console.Write("Enter again! ");
                    str = Console.ReadLine();
                }
                Console.WriteLine("What do you want to edit?");
                Console.WriteLine("1. Name\n2. Age\n3. Gender\n4. City");
                str = Console.ReadLine();
                int number;
                while (!int.TryParse(str, out number) || number < 0 || number > 4)
                {
                    Console.WriteLine("Enter again! Choose 1, 2, 3 or 4! ");
                    str = Console.ReadLine();
                }

                foreach (var item in studentList)
                {
                    if (item.StudentID == id)
                    {
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine("Enter new name: ");
                                str = Console.ReadLine();
                                item.StudentName = str;
                                break;
                            case 2:
                                Console.WriteLine("Enter new age: ");
                                item.Age = studentRepo.EnterAge();
                                break;
                            case 3:
                                Console.WriteLine("Enter new gender: ");
                                item.Gender = studentRepo.EnterGender();
                                break;
                            case 4:
                                Console.WriteLine("Enter new city: ");
                                item.City = studentRepo.EnterCity();
                                break;
                        }
                    }
                }

                break;
            case 3:
                Console.WriteLine("List student information: ");
                Console.WriteLine("----------------------------------");
                foreach (var std in studentList)
                {
                    Console.WriteLine($"ID: {std.StudentID.ToString().PadRight(15)}\nName: {std.StudentName.PadRight(15)}\nAge: {std.Age.ToString().PadRight(15)}\nGender: {std.Gender.PadRight(15)}\nCity: {std.City.PadRight(15)}\n");
                    Console.WriteLine("List book borrow: ");
                    Console.WriteLine("----------------------------------");
                    foreach (var book in std.ListBook)
                    {
                        Console.WriteLine($"Type: \t{book.TypeBorrowBook}\nNumber book borrow: \t{book.NumberBorrowBook}\nAmount money: \t{book.Money}"); 
                    }
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("----------------------------------");
                }
                break;
            case 4:
                Console.WriteLine("Exit the program.");
                Environment.Exit(Environment.ExitCode);
                break;
        }
        DisplayMenu();
    }
}

