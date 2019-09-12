using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _42
    {
        public static void Main()
        {
            Console.WriteLine("Write a C# program to create a new \nstring where the first 4 characters will \nbe in lower case. If the string is less than 4 characters \nthen make the whole string in upper case.\n");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Check(str);
        }
        public static void Check(string str) 
        {
            if (str.Length <= 4)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                string newStr;
                newStr = str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4);

                Console.WriteLine(newStr);
            }
        }
    }
}
