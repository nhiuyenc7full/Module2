using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Shape
{
    class TestShape
    {
        static void Main()
        {
            #region Bài Shape
            //Console.WriteLine("Khoi tao hinh chu nhat canh 10x20: ");
            //Rectangle rectangle = new Rectangle(10, 20);
            //Console.WriteLine("Canh cua hinh chu nhat: ");
            //rectangle.getSide();
            ////rectangle.TosTring(); 

            //Console.Write("Dien tich hinh chu nhat: ");
            //Console.WriteLine(rectangle.Area());
            //Console.WriteLine();

            //Console.WriteLine("Khoi tao tron ban kinh mac dinh 10: ");
            //Circle circle = new Circle();
            //Console.Write("Ban kinh hinh tron: ");
            //Console.WriteLine(circle.getRadius());
            //Console.WriteLine();

            //Console.WriteLine("Khoi tao hinh vuong canh mac dinh 10: ");
            //Square square = new Square();
            //Console.WriteLine(square.Area());
            //Console.WriteLine();

            //Console.WriteLine("Khoi tao hinh vuong canh 40, toa do (20,30): ");
            //Square square1 = new Square(20, 30, 40);
            //Console.WriteLine("Doi toa do hinh vuong canh (10, 12): ");
            //square1.Move(10, 12);
            //Console.WriteLine();
            //Console.WriteLine(square1.Area());

            #endregion

            #region
            Square square = new Square();
            square.Move(2, 3, 4);
            square.Scale(2);
            square.ToString();
            Console.ReadKey();
            #endregion
        }
    }
}
