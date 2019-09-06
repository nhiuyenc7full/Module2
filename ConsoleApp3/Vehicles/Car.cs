using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class Car : Vehicle
    {
        private string type;
        private int speed;

        private string idCar = "CAR";
        private static int count = 0;
        private string id;

        public Car()
        {
            count++;
            id = idCar + count;
        }

        public string Type { get => type; set => type = value; }
        public int Speed { get => speed; set => speed = value; }

        public override void ToString()
        {
            Console.WriteLine("Xe thuoc hang: " + Make + ", doi: " + Model + ", nam: " + Year + ", loai: " + Type + ", toc do: " + Speed + ", id xe: " + id);
        }
    }
}
