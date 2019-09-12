using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _43
    {
        public static void Main()
        {
            Console.WriteLine("CHECK IF A STRING STARTS  'W' AND FOLLOWED BY 'WW'.");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            CheckStr(str);
        }
        public static void CheckStr(string str)
        {
            if (str.StartsWith('w'))
            {
                Console.WriteLine((str.Substring(1, 2) == "ww") ? true : false);
            }
            else
            {
                Console.WriteLine("String does not start with 'w'");
            }
        }
    }
}
