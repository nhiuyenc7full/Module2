using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Table
{
    class Table
    {
        private int _width;
        private int _height;

        public Table()
        {
            _width = 2;
            _height = 5;
        }
        public Table(int w, int h)
        {
            _width = w;
            _height = h;
        }

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public void ShowData()
        {
            Console.WriteLine("The width is " + Width + " and the height is " + Height);
        }

    }
}
