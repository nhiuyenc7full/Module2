using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _32
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            //string str = "The quick brown fox jumps over the lazy dog.";

            int l = str.Length;
            string newStr = "";

            if (str.Length < 4)
            {
                newStr = str;
            }
            else
            {
                newStr = str.Substring(l - 4, 4);
                newStr += newStr ;
                newStr += newStr;
                Console.WriteLine(newStr);
            }

        }
        
    }
}
