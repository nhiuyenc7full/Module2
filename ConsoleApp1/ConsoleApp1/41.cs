using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _41
    {
        public static void Main()
        {
            Console.WriteLine("CHECK IF A STRING CONTAINS 'W' BETWEEN 1 AND 3 TIMES");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Check(str);
        }
        public static void Check(string str)
        {
            if (str.Length == 0)
            {
                Console.WriteLine("Empty string! ");
            }
            else
            {
                int count = 0;
                for (var i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'w')
                    {
                        count++;
                    }
                }
                Console.WriteLine((count >= 1 && count <= 3) ? true : false);
            }
        }
    }
}

