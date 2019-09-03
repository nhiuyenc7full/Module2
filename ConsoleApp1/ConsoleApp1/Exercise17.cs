using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise17
    {
        static void Main()
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            char s = str[0];
            string newString = s + str + s;
            Console.WriteLine(newString);
            Console.ReadKey();

        }
    }
}
