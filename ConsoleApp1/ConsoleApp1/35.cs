using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _35
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number: ");
            string str = Console.ReadLine();
            int number1, number2;

            while (!Int32.TryParse(str, out number1))
            {
                Console.WriteLine("Enter a NUMBER: ");
                str = Console.ReadLine();
            }
            Console.WriteLine("Number 1: " + number1);

            Console.WriteLine("\nEnter second number: ");
            str = Console.ReadLine();
            while (!Int32.TryParse(str, out number2))
            {
                Console.WriteLine("Enter a NUMBER: ");
                str = Console.ReadLine();
            }
            Console.WriteLine("Number 2: " + number2);

            Console.WriteLine();
            Console.WriteLine((number1 < 100 && number2 > 200)||(number2 < 100 && number1 > 200));
        }
    }
}
