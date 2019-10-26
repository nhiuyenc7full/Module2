using System;
using System.Collections.Generic;

namespace Practice7_1
{
    public class Program
    {
        public static Dictionary<int, User> userList = new Dictionary<int, User>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello teacher!");
            DisplayMenu();
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*       USER MANAGEMENT SYSTEM      *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Add User                   *");
            Console.WriteLine("\t\t\t*     2. Check User                 *");
            Console.WriteLine("\t\t\t*     3. Display all Users          *");
            Console.WriteLine("\t\t\t*     4. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3 or 4");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 4)
            {
                Console.Write("Enter again! Choose from 1 to 4!\t");
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
                    CreateUser();
                    break;
                case 2:
                    CheckUser();
                    break;
                case 3:
                    DisplayUser();
                    break;
                case 4:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }

        public static void DisplayUser()
        {
            Console.WriteLine("\t\tDisplay all  users...\n");
            foreach (var id in userList.Keys)
            {
                userList[id].Display();
                foreach (var item in userList[id].PhoneList)
                {
                    Console.WriteLine("Phone number: {0}", item);
                }
            }
        }

        public static void CheckUser()
        {
            Console.WriteLine("\t\tCheck User...\n");
            Console.Write("Enter ID: ");
            string str = Console.ReadLine();
            int id = CheckNumber(str);
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (!userList.ContainsKey(id))
            {
                Console.WriteLine("Not found the ID! ");
            }
            else
            {
                if (userList[id].Password == password)
                {
                    Console.WriteLine("User Checked! ");
                }
                else Console.WriteLine("User not found! ");
            }

        }

        public static void CreateUser()
        {
            Console.WriteLine("\t\tAdd User:\n");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User user = new User(name, password);

            Console.WriteLine("\nEnter number of phones:...");
            Console.Write("How many phone numbers you want to add? ");
            string str = Console.ReadLine();
            int numberOfPhone = CheckNumber(str);
            int count = 0;
            do
            {
                Console.Write($"Enter your {count + 1} phone number: ");
                str = Console.ReadLine();
                int phoneNumber = CheckNumber(str);
                user.PhoneList.Add(phoneNumber);
                count++;
            }
            while (count < numberOfPhone);
            Console.WriteLine("\t\t\nAdd the phone number...");
            userList.Add(user.ID, user);
            Console.WriteLine("\t\t\nAdded user to the list...");
        }

        public static int CheckNumber(string str)
        {
            int phoneNumber;
            while (!int.TryParse(str, out phoneNumber) || phoneNumber < 0)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return phoneNumber;
        }
    }
}
