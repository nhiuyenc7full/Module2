using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _21
    {
        static void Main ()
        {
            int x, y;
            Console.WriteLine("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y) == 20);
        }
    }
}
