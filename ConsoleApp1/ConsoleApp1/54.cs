using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _54
    {
        public static void Main()
        {
            Console.Write("Enter a year: ");
            string str = Console.ReadLine();
            int year;
            do
            {
                while (!int.TryParse(str, out year))
                {
                    Console.WriteLine("Enter again!");
                    str = Console.ReadLine();
                }
                if (year < 0)
                {
                    Console.WriteLine("Enter again!");
                    str = Console.ReadLine();
                }
            }
            while (year < 0);
            Console.WriteLine("The century of year {0} is: {1}.", year, centuryFromYear(year));
            
        }
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + (year % 100 == 0 ? 0 : 1);
        }
    }
}
