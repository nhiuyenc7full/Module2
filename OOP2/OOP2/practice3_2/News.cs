using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace practice3_2
{
    class News : INews
    {
        private int _iD = 0;
        private string _title;
        private DateTime _publishDate;
        private string _author;
        private string _content;
        private float _averageRate = 0;
        private List<int> rateList;
        private static int idNews = 0;

        public int ID { get => _iD; set => _iD = value; }
        public string Title { get => _title; set => _title = value; }
        public DateTime PublishDate { get => _publishDate; set => _publishDate = value; }
        public string Author { get => _author; set => _author = value; }
        public string Content { get => _content; set => _content = value; }
        public float AverageRate { get => _averageRate; private set => _averageRate = value; }
        public static int IdNews { get => idNews; set => idNews = value; }
        public List<int> RateList { get => rateList; set => rateList = value; }

        public News()
        {
            ID = IdNews + ID;
            Title = String.Empty;
            PublishDate = DateTime.Now;
            Author = string.Empty;
            Content = string.Empty;
            IdNews++;
            RateList = new List<int>();

            Console.WriteLine(rateList.Count);


        }

        public News(string title, DateTime publishDate, string author, string content)
        {
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            ID = IdNews + ID;
            IdNews++;
            RateList = new List<int>();
        }


        //public int this[int index]
        //{
        //    get
        //    {
        //        return rateList[index];
        //    }
        //    set
        //    {
        //        rateList[index] = value;
        //    }
        //}

        public double Calculate()
        {
            int sum = 0;
            foreach (var item in rateList)
            {
                sum += item;
            }
            return AverageRate = (float) sum/rateList.Count;
        }

        public void Display()
        {
            Console.WriteLine(RateList.Count);
            Console.WriteLine($"ID: {ID}; Title: {Title}, publish date: {PublishDate}, author: {Author}, content: {Content}, average rate: {Calculate()}.");
        }
    }
}
