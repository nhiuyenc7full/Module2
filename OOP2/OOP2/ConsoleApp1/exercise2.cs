using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.practice1
{
    class exercise2
    {
        public static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            while (name == " ") // check đầu vào chuỗi rỗng
            {
                Console.Write("Enter again!");
                name = Console.ReadLine();
            }
            age:
            Console.Write("Enter your age: ");
            string str = Console.ReadLine();
            int age;

            if (!int.TryParse(str, out age) || age < 20)
            {
                goto age;
            }
            Console.WriteLine($"Welcome {name}.");
        }
    }
}
