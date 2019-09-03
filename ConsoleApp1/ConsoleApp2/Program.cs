using System;

namespace ConsoleApp2 
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = " 1234 ";
            //str.Trim();
            //Console.WriteLine(str.Length);
            //double num = Math.Round(3.56, 1);
            //Console.WriteLine(num);

            //List<double> scores = new List<double>() { 0.5, 1.6, 2.7 };
            //scores.Add(3.8);
            //Console.WriteLine(scores.Count);

            //Nhập vào điểm của một học sinh (0 - 10) nếu nhập ký tự hoặc vượt khoảng thì bắt nhập lại.

            double num;
            bool score;
            string result;

            Console.Write("Enter the score: ");
            result = Console.ReadLine();
            score = double.TryParse(result, out num);

            while (!score || num > 10 || num < 0)
            {
                result = Console.ReadLine();
                score = double.TryParse(result, out num);
            }
            Console.WriteLine($"Your score is {num}");

            //while (num > 10 || num < 0)
            //{
            //    Console.WriteLine("Error");
            //    result = Console.ReadLine();
            //}

            Console.ReadKey();
        }
    }
}
