using System;

namespace Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*      ACCOUNT MANAGEMENT SYSTEM    *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Create account             *");
            Console.WriteLine("\t\t\t*     2. Pay into                   *");
            Console.WriteLine("\t\t\t*     3. Show info                  *");
            Console.WriteLine("\t\t\t*     4. Exit                       *");
            Console.WriteLine("\t\t\t*************************************\n");

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
                    AccountList.CreateAccount();
                    Console.WriteLine("Create finish...");
                    break;
                case 2:
                    Console.WriteLine("Enter id want to put in/ draw money: ");
                    int id;
                    string str = Console.ReadLine();
                    while (!int.TryParse(str, out id) || id < 0)
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    bool check = false;
                    foreach (var item in AccountList.accounts)
                    {
                        if (item.AccountId == id)
                        {
                            Console.WriteLine("Enter money:");
                            int money;
                            str = Console.ReadLine();
                            while (!int.TryParse(str, out money) || money < 0)
                            {
                                Console.Write("Enter again! ");
                                str = Console.ReadLine();
                            }

                            Console.WriteLine("Want to draw (press 1)/ put in (press 2): ");
                            int number;
                            str = Console.ReadLine();
                            while (!int.TryParse(str, out number) || number > 2 || number < 1)
                            {
                                Console.Write("Enter again! ");
                                str = Console.ReadLine();
                            }
                            switch (number)
                            {
                                case 1:
                                    item.Balance -= money;
                                    break;
                                case 2:
                                    item.Balance += money;
                                    break;
                            }
                            check = true;
                        } 
                        if (check)
                        {
                            Console.WriteLine("Succeeded.");
                        }
                        else
                        {
                            Console.WriteLine("Not found ID.");
                        }
                    }
                    AccountList.PayInto();
                    break;
                case 3:
                    AccountList.ShowData();
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
