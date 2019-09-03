using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x > 0 && y < 0) || (x < 0 && y > 0));

            Console.ReadKey();
        }
    }
}
