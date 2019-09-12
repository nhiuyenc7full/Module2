using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _45
    {
        public static uint num;
        public static int numInt, numCheck;
        public static int[] arr;
        public static int count = 0;
        public static void Main()
        {
            Console.WriteLine("Write a C# program to count a specified number in a given array of integers.");
            Console.WriteLine("Enter an array: ");
            EnterArray();
            Console.Write("Enter the number need to check: ");
            string str = Console.ReadLine();
            CheckInt(str);
            numCheck = numInt;
            CheckAppear(arr, numCheck);
            Console.WriteLine($"Number of {numCheck} presented in the said array: {count}");

        }
        public static void EnterArray()
        {
            
            Console.Write("Enter the length of the array: ");
            string str = Console.ReadLine();
            CheckLength(str);
            arr = new int [num];
            for (var i = 0; i < num; i++)
            {
                Console.Write($"Enter the element {i} of the array: ");
                str = Console.ReadLine();
                CheckInt(str);
                arr[i] = numInt;
            }

        }
        public static void CheckLength(string str)
        {
            uint n;
            while (!uint.TryParse(str, out n))
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            num = n;
        }
        public static void CheckInt(string str)
        {
            int n;
            while (!int.TryParse(str, out n))
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            numInt = n;
        }
        public static void CheckAppear(int[] arr, int numCheck)
        {
            for (int i = 0; i < num; i++)
            {
                if (arr[i] == numCheck)
                {
                    count++;
                }
            }
        }

    }
}
