using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.House
{
    class Program
    {
        public static void Main()
        {
            House house = new House();
            house.Area = 300;
            Console.WriteLine(house.Area);
            house.GetDoor();
            house.GetDoor();
            Console.WriteLine(House.count);

            Door door = new Door();

            //Console.WriteLine(House.count);
            Console.WriteLine(door.Color);
        }
    }
}
