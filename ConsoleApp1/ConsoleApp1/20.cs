using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _20
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(50, 45));
            Console.WriteLine(result(50, 75));
            Console.WriteLine(result(50, 51));
        }
        public static int result(int x, int y)
        {
            if (x > y)
            {
                return (x - y) * 2;
            }
            else return y - x;
        }
    }
}
