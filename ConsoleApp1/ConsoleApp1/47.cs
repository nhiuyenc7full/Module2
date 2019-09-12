using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _47
    {
        public static void Main()
        {
            Console.WriteLine("Write a C# program to compute the sum of all the elements of an array of integers.\n");
            Console.WriteLine("*********************************************");
            
            int sum = 0;
            int[] arr = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"The sum of all elements is: {sum}.");
        }
    }
}
