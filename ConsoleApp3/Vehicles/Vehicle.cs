using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class Vehicle
    {
        private string make;
        private string model;
        private uint year;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public uint Year { get => year; set => year = value; }

        public Vehicle()
        {
            make = "BMW";
            model = "BMW19";
            year = 2019;
        }
        public Vehicle(string ma, string mo, uint ye)
        {
            make = ma;
            model = mo;
            year = ye;
        }
        public virtual void ToString()
        {
            Console.WriteLine("Xe thuoc hang: " + make + ", doi: " + model + ", nam: " + year);
        }
    }
}
