using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _56
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(isPalindrome(str));
        }
        public static bool isPalindrome(string str)
        {
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
