using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.practice1
{
    class exercise1
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

            Console.Write("Enter your age: ");
            string str = Console.ReadLine();
            int age;

            while (!int.TryParse(str, out age) || age < 0)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }
        
    }
}
