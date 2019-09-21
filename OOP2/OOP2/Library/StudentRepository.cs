using System;
using System.Collections.Generic;
using System.Text;
using BorrowBook;

namespace Library
{
    public class StudentRepository
    {
        public int EnterAge()
        {
            int age;
            string str = Console.ReadLine();
            while (!int.TryParse(str, out age) || age < 18 || age > 100)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            return age;
        }

        public string EnterGender()
        {
            string str = (Console.ReadLine()).ToLower();
            do
            {
                if (str.Equals("male"))
                {
                    return str;
                }
                else if (str.Equals("female"))
                {
                    return str;
                }
                else
                {
                    str = (Console.ReadLine()).ToLower();
                }
            }
            while (true);
        }

        public string EnterCity()
        {
            string str = Console.ReadLine();
            while (str.Length < 4 || str.Length > 40)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            return str;
        }
    }
}
