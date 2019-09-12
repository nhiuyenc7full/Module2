using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _52
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };
            int[] newArray = new int[] { array1[1], array2[1], array3[1] };
            Console.WriteLine("Array 1: [{0}].", string.Join(", ", array1));
            Console.WriteLine("Array 1: [{0}].", string.Join(", ", array2));
            Console.WriteLine("Array 1: [{0}].", string.Join(", ", array3));
            Console.WriteLine("New Array: [{0}].",string.Join(", ", newArray));
        }
    }
}
