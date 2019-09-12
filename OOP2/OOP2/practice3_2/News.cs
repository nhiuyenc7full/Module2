using System;
using System.Collections.Generic;
using System.Text;

namespace practice3_2
{
    class News : INews
    {
        private int iD;
        private string title;
        private DateTime publishDate;
        private string author;
        private string content;
        private float averageRate;
        private int[] rateList = new int[3];

        public int ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverageRate { get => averageRate; }
        public int[] RateList { get => rateList; set => rateList = value; }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, publish date: {PublishDate}, author: {Author}, content: {Content}, average rate: {AverageRate}.");
        }

    }
}
