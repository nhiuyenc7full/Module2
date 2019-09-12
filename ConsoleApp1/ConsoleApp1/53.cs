using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _53
    {
        public static void Main()
        {
            int[] array = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Array: [{0}].", string.Join(", ", array));
            Console.WriteLine("The array contains an odd? " + check_odd(array));
        }
        public static bool check_odd(int[] array)
        {
            foreach (var n in array)
            {
                if (n % 2 != 0) return true;
            }
            return false;
        }
    }
}
