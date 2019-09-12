using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.practice1
{
    class Exercise3
    {
        private static int inputInt;
        public static void Main()
        {
            Console.Write("Enter the number: ");
            string str = Console.ReadLine();
            
            while (!int.TryParse(str,out inputInt))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }

            int giai_thua(int n)
            {
                if (n == 2) return 2;
                return n * giai_thua(n - 1);
            }
            Console.WriteLine(giai_thua(inputInt));
        }
    }
}
