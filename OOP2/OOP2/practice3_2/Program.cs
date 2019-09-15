using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace practice3_2
{
    class Program
    {
        static NewsRepository NewsRepo = new NewsRepository();
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\t******************************");
            Console.WriteLine("\t*   NEWS MANAGEMENT SYSTEM   *");
            Console.WriteLine("\t*     1. Insert news         *");
            Console.WriteLine("\t*     2. View list news      *");
            Console.WriteLine("\t*     3. Exit                *");
            Console.WriteLine("\t******************************");

            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 1 || choose > 3)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }

        static void ChooseMenu(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    InsertNews();
                    break;
                case 2:
                    ViewListNews();
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();

        }
        public static void InsertNews()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter PublishDate: ");
            string str = Console.ReadLine();
            DateTime publishDate;
            while (!DateTime.TryParse(str, out publishDate))
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Content: ");
            string content = Console.ReadLine();

            News news = new News(title, publishDate, author, content);

            Console.WriteLine("Enter rate for this News: ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} rate: ");
                str = Console.ReadLine();
                news.RateList.Add(GetRate(str));
            }
            NewsRepo.NewsList.Add(news.ID, news);
        }

        public static int GetRate(string str)
        {
            int rate;
            while (!int.TryParse(str, out rate) || rate < 1 || rate > 3)
            {
                Console.WriteLine("You must enter the rate from 1 to 3!");
                str = Console.ReadLine();
            }
            return rate;
        }

        public static void ViewListNews()
        {
            foreach (News item in NewsRepo.NewsList.Values)
            {
                item.Display();
            }

        }

    }
}
