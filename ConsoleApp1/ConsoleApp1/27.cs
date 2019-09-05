using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _27
    {
        static void Main()
        {
            Console.WriteLine("Enter the number (integer): ");
            int number = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
