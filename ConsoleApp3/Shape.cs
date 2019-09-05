using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Shape
    {
        protected Location c;

        public string ToString()
        {
            return " ";
        }
        public double Area()
        {
            return 0.000;
        }
        public double Perimeter()
        {
            return 0.000;
        }
    }
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
    }
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
    }
    class Location
    {
        private double x, y;
    }

    class TestShape
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.getSide();

            Circle circle = new Circle();
            Console.WriteLine(circle.getRadius());
        }
    }
}
