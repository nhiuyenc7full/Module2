using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _46
    {
        public static void Main()
        {
            Console.WriteLine("Write a C# program to check if a number\n" +
                "appears as either the first or last element of an\n" +
                "array of integers and the length is 1 or more.\n");
            Console.WriteLine("*********************************************");
            int[] arr = new int[] { 1, 4, 7, 7, 5, 1};
            Console.Write("Enter the number want to check: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(arr[0] == num && arr[arr.Length - 1] == num);
         
        }
    }
}
