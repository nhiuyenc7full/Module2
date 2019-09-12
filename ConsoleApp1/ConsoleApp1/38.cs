using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _38
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string result = "";
            if (str.StartsWith("PH"))
            {
                result = "PH";
            }
            Console.WriteLine(result);
        }
    }
}
