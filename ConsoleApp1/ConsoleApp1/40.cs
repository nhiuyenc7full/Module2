using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _40
    {
        private static int x, y, result;
        private static void Main()
        {
            Console.WriteLine("FIND THE NEAREST VALUE OF 20");
            EnterNumber();
            int n = 20;
            int xAbs = Math.Abs(x - n);
            int yAbs = Math.Abs(y - n);
            Console.WriteLine(xAbs == yAbs ? 0 : xAbs > yAbs ? y: x);
        }
        public static void Check(string str)
        {
            while (!Int32.TryParse(str, out result))
            {
                Console.WriteLine("Enter the number again: ");
                str = Console.ReadLine();
            }
        }
        public static void EnterNumber()
        {
            Console.WriteLine("Enter two numbers: ");
            string str = Console.ReadLine();
            Check(str);
            x = result;
            str = Console.ReadLine();
            Check(str);
            y = result;
            Console.WriteLine($"Two numbers: {x}, {y}");
        }
    }
}
