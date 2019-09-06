using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Shape
{
    class Square : Shape
    {
        Location l = new Location();

        private int _side;
        private int _x;
        private int _y;
        public Square()
        {
            _x = l.X;
            _y = l.Y;
            _side = l.S;
        }
        public Square(int x, int y, int side)
        {
            _x = x;
            _y = y;
            _side = side;
        }
        public void Move(int a, int b)
        {
            l.X = a;
            l.Y = b;

        }

        public void Move(int a, int b, int c)
        {
            l.X = a;
            l.Y = b;
            l.S = c;

        }

        public void Scale(int factor)
        {
            l.S = l.S * factor;
        }
        public void ToString()
        {
            Console.WriteLine("Corner (" + l.X / 2 + "), side " + l.S); 
        }

        public new double Area()
        {
            return _side * _side;
        }
    }
}
