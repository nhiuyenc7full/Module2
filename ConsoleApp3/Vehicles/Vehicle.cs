using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class Vehicle
    {
        private string make;
        private string model;
        private int year;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        public Vehicle()
        {
            make = "BMW";
            model = "BMW19";
            year = 2019;
        }
        public Vehicle(string ma, string mo, int ye)
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
