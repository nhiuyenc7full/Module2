using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _58
    {
        private static int arrayLength;
        private static string str;
        private static int inputNum;
        private static int[] array;
        public static void Main()
        {
            enter_array();
            Array.Sort(array);
            Console.WriteLine("The amount of integer needed to complete the rank: {0}", array[array.Length -1] - array[0] - array.Length + 1);
         }
        public static int convert_integer(string str)
        {
            while (!int.TryParse(str, out inputNum))
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            return inputNum;
        }
        public static void enter_array()
        {
            
            Console.Write("Enter the length of the array: ");
            str = Console.ReadLine();
            while (convert_integer(str) < 0)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            arrayLength = convert_integer(str);
            array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the element {i} of the array: ");
                str = Console.ReadLine();
                array[i] = convert_integer(str);
            }
            Console.WriteLine("Array: [{0}].", string.Join(", ", array));
        }
    }
}
