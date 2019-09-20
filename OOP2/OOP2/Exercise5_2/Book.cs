using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5_2
{
    public class Book : IBook
    {
        private int _iD;
        private string _name;
        private DateTime _publishDate;
        private string _author;
        private string _language;
        private float _averagePrice;
        private List<int> _priceList;
        private static int idCount = 1;

        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime PublishDate { get => _publishDate; set => _publishDate = value; }
        public string Author { get => _author; set => _author = value; }
        public string Language { get => _language; set => _language = value; }
        public float AveragePrice { get => Calculate(); }
        public List<int> PriceList { get => _priceList; set => _priceList = value; }

        public Book()
        {
            ID = ID + idCount;
            idCount++;
        }
        public Book(string name, DateTime publishDate, string author, string language, List<int> priceList)
        {
            Name = name;
            PublishDate = publishDate;
            Author = author;
            Language = language;
            PriceList = priceList;
            ID = ID + idCount;
            idCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}\tPublish Date: {PublishDate}\tAuthor: {Author}\tLanguage: {Language}\tAverage Price: {AveragePrice}\n");
        }

        public float Calculate()
        {   
            int sum = 0;
            foreach (var item in PriceList)
            {
                sum += item;
            }
            return (float)sum / PriceList.Count;
        }


    }
}
