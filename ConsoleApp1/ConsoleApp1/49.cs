using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _49
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine((array1[0].Equals(array2[array2.Length - 1])) || (array2[0].Equals(array1[array1.Length - 1])));
        }
    }
}
