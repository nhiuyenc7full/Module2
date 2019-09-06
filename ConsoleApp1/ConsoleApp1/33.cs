using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _33
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number: ");
            string str = Console.ReadLine();
            int num = 0;
            while (num <= 0)
            {
                while (!Int32.TryParse(str, out num))
                {
                    Console.WriteLine("You must enter a positive NUMBER: ");
                    str = Console.ReadLine();
                }
                if (num <= 0)
                {
                    Console.WriteLine("You must enter a POSITIVE number: ");
                    str = Console.ReadLine();
                }
            }
            

            Console.WriteLine((num % 3 == 0 || num % 7 == 0) ? true : false);
        }
    }
}
