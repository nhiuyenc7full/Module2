using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.House
{
    class Door
    {
        private string color;
        public string Color { get => color; set => color = value; }
        public Door()
        {
            color = "brown";
        }
        public Door(string brown)
        {
            color = brown;
        }
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is " + color);
        }
    }
}
