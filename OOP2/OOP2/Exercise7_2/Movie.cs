using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_2
{
    public class Movie : IMovie
    {
        private int iD;
        private string name;
        private DateTime publishDate;
        private string director;
        private string language;
        private float averageRate;
        private double[] rateList;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Director { get => director; set => director = value; }
        public string Language { get => language; set => language = value; }
        public float AverageRate { get => Calculate(); }
        public double[] RateList { get => rateList; set => rateList = value; }

        public Movie()
        {
            double[] rateList = new double[3];

        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nPublish date: {PublishDate}\nDirector: {Director}\nLanguage: {Language}\nAverage rate: {AverageRate}");
        }
        public float Calculate()
        {
            return (float) (rateList[0] + rateList[1] + rateList[2])/3;
        }
    }
}
