using System;

namespace practice2_1
{
    class Product
    {
        private string _name;
        private string _decription;
        private double _price;
        private int[] _rate;

        public string Name { get => _name; set => _name = value; }
        public string Decription { get => _decription; set => _decription = value; }
        public double Price { get => _price; set => _price = value; }
        public int[] Rate { get => _rate; set => _rate = value; }
        

        public Product(string name, string description, double price)
        {
            _name = name;
            _decription = description;
            _price = price;
        }
        public void ViewInfor()
        {
            Console.WriteLine("Name: {0}; price: {1}; decription: {2}", _name, _price, _decription);
        }
    }
}
