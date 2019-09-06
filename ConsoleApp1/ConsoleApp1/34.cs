using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _34
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter the specified word: ");
            string speWord = Console.ReadLine();

            Console.WriteLine(str.StartsWith(speWord));

            //Kiểm tra xem chuỗi str có bằng chuỗi speWord không.
            //Console.WriteLine(str.Equals(speWord)); 
        }


    }
}
