using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class PostRepository
    {
        public List<Post> postList = new List<Post>();
        public void CreatePost()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter content: ");
            string content = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.Write("Enter rate 1: ");
            int rate1 = CheckRate(Console.ReadLine());
            Console.Write("Enter rate 2: ");
            int rate2 = CheckRate(Console.ReadLine());
            Console.Write("Enter rate 3: ");
            int rate3 = CheckRate(Console.ReadLine());
            Console.Write("Enter rate 4: ");
            int rate4 = CheckRate(Console.ReadLine());
            Post post = new Post(title, content, author);
            post.Rates = new int[] { rate1, rate3, rate3, rate4 };

            postList.Add(post);
        }

        public void Calculator()
        {
            foreach (var item in postList)
            {
                item.CalculatorRate();
            }
        }

        public void ShowList()
        {
            foreach (var item in postList)
            {
                item.Display();
                Console.WriteLine("-------------");
            }
        }

        public int CheckRate(string str)
        {
            int rate;
            while(!int.TryParse(str, out rate) || rate <= 0)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            return rate;
        }
    }
}
