using System;
using System.Collections.Generic;

namespace OOP
{
    //khởi tạo n HCN, xuất ra các hcn đó (ToString());



    class Shape1
    {
        private int side;

        public int Side { get => side; set => side = value; }
        public virtual void ToString1()
        {
            Console.WriteLine("No shapes");
        }
    }
    class Square1 : Shape1
    {
        public override void ToString1()
        {
            Console.WriteLine($"square side: {Side}");
        }
    }
    class test
    {
        static void Main()
        {

            Console.Write("Enter a amount of square: ");
            string str = Console.ReadLine();
            int n = Convert.ToInt32(str);
            List<Square1> squaList = new List<Square1>();

            Square1 squa;
            for (var i = 0; i < n; i++)
            {
                squa = new Square1();
                squa.Side = Convert.ToInt32(Console.ReadLine());
                squaList.Add(squa);
            }
            foreach (var i in squaList)
            {
                i.ToString1();
            }
            Console.ReadKey();


        }
    }
}

