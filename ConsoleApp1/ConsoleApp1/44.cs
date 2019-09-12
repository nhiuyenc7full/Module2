using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _44
    {
        public static void Main()
        {
            Console.WriteLine("Write a C# program to create a new string of\n" +
                "every other character (odd position) from the first\n" +
                "position of a given string.\n");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            MakeString(str);
        }
        public static void MakeString(string str)
        {
            string newStr = string.Empty;
            for (var i = 0; i < str.Length; i+=2)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);
        }
    }
}
