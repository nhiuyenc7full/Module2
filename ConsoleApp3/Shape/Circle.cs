using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Shape
{
    class Circle : Shape
    {
        private double radius;
        public Circle()
        {
            radius = 10;
        }
        public double getRadius()
        {
            return radius;
        }
        public new double Area()
        {
            return 3.14 * radius * radius;
        }
    }
}
