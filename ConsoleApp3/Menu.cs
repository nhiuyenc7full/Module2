using System;
using System.Collections.Generic;
using System.Text;
//Menu cho việc cần làm
//Khởi tạo một hình tròn, xuất chu vi, diện tích của nó
//Khởi tạo hình vuông, xuất...
//Khởi tại hình CN, xuất...
//Thoát khỏi chương trình
namespace OOP
{
    class Menu
    { 
        private static void Main()
        {
            Circle circle = new Circle();
            Rectangle square = new Rectangle(10, 10);
            Rectangle rectangle = new Rectangle(20, 10);
            int choose;

            do
            {
                chooseShape();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine(circle.Area());
                        break;
                    case 2:
                        Console.WriteLine(square.Area());
                        break;
                    case 3:
                        Console.WriteLine(rectangle.Area());
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Enter again");
                        break;
                }
            } while (choose != 4);
        }

        public static void chooseShape()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1: Hinh tron");
            Console.WriteLine("2: Hinh vuong");
            Console.WriteLine("3: Hinh chu nhat");
        }
    }

    
}
