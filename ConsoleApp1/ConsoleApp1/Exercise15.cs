using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 0));
            Console.WriteLine(remove_char("w3resource", 8));
            Console.ReadKey();
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
