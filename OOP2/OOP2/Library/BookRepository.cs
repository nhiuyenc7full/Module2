using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Library;

namespace BorrowBook
{
    public class BookRepository
    {
        private Hashtable typeBook = new Hashtable();
        public Hashtable TypeBook { get => typeBook;}

        public void DisplayMenuBook(Student student)
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*        BOOKS LIST CAN BORROW      *");
            Console.WriteLine("\t\t\t*     Type book:       Rate:        *");
            Console.WriteLine("\t\t\t*   1. Major           5            *");
            Console.WriteLine("\t\t\t*   2. Literature      3            *");
            Console.WriteLine("\t\t\t*   3. Reference       4            *");
            Console.WriteLine("\t\t\t*   4. Other...        6            *");
            Console.WriteLine("\t\t\t*   5. Exit                         *");
            Console.WriteLine("\t\t\t*************************************\n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3 or 4");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 5)
            {
                Console.WriteLine("Enter again! Choose 1, 2, 3 or 4! ");
                str = Console.ReadLine();
            }
            ChooseMenu(choose, student);
        }
        public void ChooseMenu(int choose, Student student)
        {
            Book book;
            Console.Clear();
            switch (choose)
            {
                case 1:
                    book = new Book();
                    student.ListBook.Add(book);
                    book.TypeBorrowBook = "major";
                    book.AcceptDetails();
                    Console.WriteLine("You choose Major...");
                    break;
                case 2:
                    book = new Book();
                    student.ListBook.Add(book);
                    book.TypeBorrowBook = "literature";
                    book.AcceptDetails();
                    Console.WriteLine("You choose Literature...");
                    break;
                case 3:
                    book = new Book();
                    student.ListBook.Add(book);
                    book.TypeBorrowBook = "reference";
                    book.AcceptDetails();
                    Console.WriteLine("You choose Reference...");
                    break;
                case 4:
                    book = new Book();
                    student.ListBook.Add(book);
                    book.TypeBorrowBook = "other";
                    book.AcceptDetails();
                    Console.WriteLine("You choose Other...");
                    break;
                case 5:
                    Program.DisplayMenu();
                    break;
            }
            DisplayMenuBook(student);
        }
        public void EnterBookLibrary()
        {
            TypeBook.Add("major", 5);
            TypeBook.Add("literature", 3);
            TypeBook.Add("reference", 4);
            TypeBook.Add("other", 6);
        }
    }
}
