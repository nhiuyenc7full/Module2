using System;
using System.Collections;

namespace Exercise6_1
{
    public class Program
    {
        static PhoneBook phoneBook = new PhoneBook();
        static SortedList listPhoneBook = new SortedList();
        public static void Main(string[] args)
        {
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*    PHONEBOOK MANAGEMENT SYSTEM    *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Insert phone               *");
            Console.WriteLine("\t\t\t*     2. Remove phone               *");
            Console.WriteLine("\t\t\t*     3. Update phone               *");
            Console.WriteLine("\t\t\t*     4. Search phone               *");
            Console.WriteLine("\t\t\t*     5. Sort                       *");
            Console.WriteLine("\t\t\t*     6. Exit                       *");
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
                    Console.WriteLine("\t\tInsert phone: ");
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone: ");
                    string str = Console.ReadLine();
                    int phone;
                    while(!int.TryParse(str, out phone) || phone < 0)
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    phoneBook.InsertPhone(name, phone);
                    break;
                case 2:
                    Console.WriteLine("\t\tRemove phone: ");
                    Console.Write("Enter name:");
                    name = Console.ReadLine();
                    phoneBook.RemovePhone(name);
                    break;
                case 3:
                    Console.WriteLine("\t\tUpdate phone:");
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter phone: ");
                    str = Console.ReadLine();
                    while (!int.TryParse(str, out phone) || phone < 0)
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    phoneBook.UpdatePhone(name, phone);
                    break;
                case 4:
                    Console.Write("Search phonename: ");
                    name = Console.ReadLine();
                    phoneBook.SearchPhone(name);
                    break;
                case 5:
                    Console.WriteLine("Sort phonebook: ");
                    phoneBook.Sort();
                    break;
                case 6:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }
    }
}
