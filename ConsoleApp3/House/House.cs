using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.House
{
    class House
    {
        private int area;

        public int Area { get => area; set => area = value; }

        public House()
        {
            area = 200;
        }
        public House(int x)
        {
            area = x;
        }
        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is " + Area + " m2");
        }
        public static int count = 0;
        public void GetDoor()
        {
            Door door = new Door();
            count++;
        }
        
    }
}
