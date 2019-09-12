using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _51
    {
        static void Main()
        {
            int[] array = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array: [{0}]", string.Join(", ", array));
            Console.Write("The highest value between first and last values: ");
            Console.WriteLine((array[0] > array[array.Length - 1]) ? array[0] : array[array.Length - 1]);
        }
    }
}
