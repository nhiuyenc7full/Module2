using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Exercise1_9
    {
        static void Main()
        {
            ////Exercise1
            //Console.WriteLine("Hello");
            //Console.WriteLine("Nhi Uyên");

            ////Exercise2
            //Console.WriteLine(1 + 1);

            ////Exercise3
            //Console.WriteLine(10 / 5);
            ///
            /// /Exercise4
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            ////Exercise5
            //Console.WriteLine();
            //int number1, number2, temp;
            //Console.Write("Input the first Number: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Input the second Number: ");
            //number2 = int.Parse(Console.ReadLine());
            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            //Console.Write("\nAfter Swapping: ");
            //Console.Write("\nFirst Number: " + number1);
            //Console.WriteLine("\nSecond Number: " + number2);

            ////Exercise6
            //int number1, number2, number3, result;
            //Console.WriteLine();
            //Console.Write("\ninput the first number to multiply: ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\ninput the second number to multiply: ");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\ninput the third number to multiply: ");
            //number3 = Convert.ToInt32(Console.ReadLine());

            //result = number1 * number2 * number3;
            //Console.WriteLine("\nThe multiplication of {0}, {1} and {2} is {3}", number1, number2, number3, result);

            //Exercise7

            int number1, number2;
            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);

            //Exercise8
            //int number;
            //Console.Write("Enter the number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The table: ");
            //for (var i = 0; i <=10; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {number*i}");
            //}

            //Exercise9
            //double number1, number2, number3, number4;
            //Console.Write("Enter the first number: ");
            //number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //number2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the third number: ");
            //number3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the fourth number: ");
            //number4 = Convert.ToDouble(Console.ReadLine());

            //double result = (number1 + number2 + number3 + number4) / 4;
            //Console.Write("The average of {0}, {1}, {2} and {3} is: {4}", number1, number2, number3, number4, result);

            //Exercise10
            Console.ReadKey();
        }
    }
}

