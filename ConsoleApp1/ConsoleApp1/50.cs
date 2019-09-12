using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _50
    {
        static void Main()
        {
            int[] array = { 1, 2, 8};
            Console.WriteLine("Array: [{0}]", string.Join(", ", array));
            var temp = array[0];
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
            Console.WriteLine("Array after rotating: [{0}]", string.Join(", ", array));
        }
    }
}
