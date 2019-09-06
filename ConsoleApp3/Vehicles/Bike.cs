using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class Bike: Vehicle
    {
        private int wheel;

        private string idBike = "CIRCLE";
        private static int count = 0;
        private string id;
        public Bike()
        {
            count++;
            id = idBike + count;
        }
        
        public int Wheel { get => wheel; set => wheel = value; }
        public override void ToString()
        {
            Console.WriteLine("Xe thuoc hang: " + Make + ", doi: " + Model + ", nam: " + Year + ", id xe: " + id);
        }
    }
}
