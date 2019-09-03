using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise19
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(3, 3));
            Console.WriteLine(SumTriple(3, 4));
            Console.WriteLine(SumTriple(5, 3));
        }
        public static int SumTriple(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
