using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Post : IPost
    {
        private static int _idCount = 1;
        private int _iD = 0;
        private string _title;
        private string _content;
        private string _author;
        private int[] _rates = new int[4];

        public int ID { get => _iD; set => _iD = value; }
        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public string Author { get => _author; set => _author = value; }
        public float AverageRate { get => CalculatorRate(); }
        public int[] Rates { get => _rates; set => _rates = value; }

        public Post()
        {
            int[] Rate = Rates;
            ID = ID + _idCount;
            _idCount++;
        }
        public Post(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
            int[] Rate = Rates;
            ID = ID + _idCount;
            _idCount++;
        }
        public void Display()
        {
            Console.WriteLine($"ID : {ID}\nTitle: {Title}\nContent: {Content}\nAuthor: {Author}\nAverage rate: {AverageRate}");
        }
        public float CalculatorRate()
        {
            int sum = (Rates[0] + Rates[1] + Rates[2] + Rates[3]);
            float average = (float) sum / 4;
            return average;
        }
    }
}
