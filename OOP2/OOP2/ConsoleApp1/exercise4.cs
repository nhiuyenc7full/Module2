using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class exercise4
    {
        public static void Main()
        {

        Menu: Menu();
            Console.WriteLine("**********");
            Console.Write("Choose the dish: ");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 && choose > 3 )
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Clear();
            switch (choose)
                {
                    case 1:
                        Console.WriteLine("Chicken");
                        goto Menu;
                    case 2:
                        Console.WriteLine("Beef");
                        goto Menu;
                    case 3:
                        Console.WriteLine("Vegetables");
                        goto Menu;
                    case 4:
                        Console.WriteLine("Exit the program");
                        break;
                    default:
                        Console.WriteLine("Choose again! ");
                        goto Menu;
                }
        }
        static void Menu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Beef");
            Console.WriteLine("3. Vegetables");
            Console.WriteLine("4. Exit menu");
        }
    }
}
