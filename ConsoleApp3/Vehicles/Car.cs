using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class Car : Vehicle
    {
        private string type;
        private uint speed;
        private string wheel;

        private string idCar = "CAR";
        private static int count = 0;
        private string iD;

        public Car() 
        {
            count++;
            iD = idCar + count;
        }
        public Car(string wheel) : base()
        {
            wheel = wheel;
        }

        public string Type { get => type; set => type = value; }
        public uint Speed { get => speed; set => speed = value; }

        public override void ToString()
        {
            Console.WriteLine("Xe thuoc hang: " + Make + ", doi: " + Model + ", nam: " + Year + ", loai: " + Type + ", toc do: " + Speed + ", id xe: " + iD);
        }
    }
}
