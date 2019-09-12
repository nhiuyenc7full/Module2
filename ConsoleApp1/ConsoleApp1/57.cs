using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _57
    {
        public static void Main()
        {
            int[] array1 = { 1, 3, 4, 5, 2 };
            int[] array2 = { 1, 3, -4, 5, 2 };
            int[] array3 = { 1, 0, -4, 0, 2 };

            Console.WriteLine("The highest product of the pair of adjcent elements of array1: " + find_Highest_Product(array1));
            Console.WriteLine("The highest product of the pair of adjcent elements of array2: " + find_Highest_Product(array2));
            Console.WriteLine("The highest product of the pair of adjcent elements of array3: " + find_Highest_Product(array3));
        }
        public static int find_Highest_Product(int[] array)
        {
            int product = array[0] * array[1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                product = (array[i] * array[i + 1] > product ? array[i] * array[i + 1] : product);
            }
            return product;
        }
    }
}
