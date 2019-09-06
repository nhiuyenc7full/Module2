using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Shape
{
    class Rectangle : Shape
    {
        private double side1, side2;
        public Rectangle(int a, int b)
        {
            side1 = a;
            side2 = b;
        }
        public void getSide()
        {
            Console.WriteLine("Side 1 = {0}", side1);
            Console.WriteLine("Side 2 = {0}", side2);
        }
        public double Area()
        {
            return side1 * side2;
        }
    }
}
