using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Table
{
    class Program
    {
        public static void Main()
        {
            Table[] table = new Table[10];
            Random size = new Random();

            for (var i = 0; i < 10; i++)
            {
                table[i] = new Table(size.Next(50, 201), size.Next(50, 201));
                table[i].ShowData();
            }
        }
    }
}
