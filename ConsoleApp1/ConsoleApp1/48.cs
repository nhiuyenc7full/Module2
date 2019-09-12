using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _48
    {
        public static void Main()
        { 
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            //Console.WriteLine((arr.Length >= 1) && arr[0] == arr[arr.Length-1]);
            Console.WriteLine((arr.Length >= 1) && (arr[0].Equals(arr[arr.Length -1])));
        }
    }
}
