using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _37
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string hp = "HP";

            if (str.Length > hp.Length)
            {
                Console.WriteLine(str.Substring(1, 2) == hp);
            }
            else Console.WriteLine("False");
                
        }
    }
}
