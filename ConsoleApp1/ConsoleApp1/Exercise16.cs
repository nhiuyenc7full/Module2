using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resoure"));
            Console.WriteLine(first_last("uyennhi"));
            Console.WriteLine(first_last("abcdef"));
        }
        public static string first_last(string str)
        {
            return str.Length > 0 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
    
    
}
