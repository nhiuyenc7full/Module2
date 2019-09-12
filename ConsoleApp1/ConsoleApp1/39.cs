using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _39
    {
        private static int x, y, z, result, max, min;
        public static void Main()
        {
            EnterNumber();

            max = Math.Max(x, Math.Max(y, z));
            min = Math.Min(x, Math.Min(y, z));

            Console.WriteLine($"Largest of three: {max}");
            Console.WriteLine($"Lowest of three: {min}");
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
            Console.WriteLine("Enter three numbers: ");
            string str = Console.ReadLine();
            Check(str);
            x = result;
            str = Console.ReadLine();
            Check(str);
            y = result;
            str = Console.ReadLine();
            Check(str);
            z = result;
            Console.WriteLine($"Three numbers: {x}, {y}, {z}");
        }
       
    }
}
