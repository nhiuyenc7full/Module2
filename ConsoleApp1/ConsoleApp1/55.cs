using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _55
    {
        
        public static void Main()
        {
            
            int[] array1 = { 2, 4, 2, 6, 9, 3 };
            int[] array2 = { 0, -1, -1, -2 };
            int[] array3 = { 6, 1, 12, 3, 1, 4 };
            int[] array4 = { 1, 4, 3, 0 };

            Console.WriteLine(array_adjacent_element_product(array1) == 27);
            Console.WriteLine(array_adjacent_element_product(array2) == 2);
            Console.WriteLine(array_adjacent_element_product(array3) == 36);
            Console.WriteLine(array_adjacent_element_product(array4) == 16);

        }
        static int array_adjacent_element_product(int[] array)
        {
            int product = array[0] * array[1];
            for (int i = 1; i < array.Length - 1; i++)
            {
                product = (array[i] * array[i + 1] )> product ? array[i] * array[i + 1] : product;
            }
            return product;
        }
    }
}
