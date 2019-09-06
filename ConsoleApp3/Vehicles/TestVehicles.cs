using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Vehicles
{
    class TestVehicles
    {
        public static uint amount = 0;
        public static List<Bike> bikeList = new List<Bike>();
        public static List<Car> carList = new List<Car>();
        public static uint n;
        public static void Main()
        {
            Menu();
            
            Bike bike;
            Car car;
        }
        static void process(int choose)
        {
                switch(choose)
                {
                    case 1:
                        {
                            number1();
                        }
                        break;
                    case 2:
                        {
                            number2();
                        }
                        break;
                    case 3:
                        {
                            number3();
                        }
                        break;

                    case 4:
                        {
                            number4();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thoat chuong trinh. ");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    default:
                        Console.WriteLine("Chon 1, 2, 3, 4 hoac 5: ");
                        Menu();
                        break;
                }
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Nhap so xe dap");
            Console.WriteLine("2. Hien thi xe dap");
            Console.WriteLine("3. Nhap so xe o to");
            Console.WriteLine("4. Hien thi xe o to");
            Console.WriteLine("5. Thoat chuong trinh");
            Console.WriteLine("**********************************");
            string str = Console.ReadLine();
            int choose;
            while (!Int32.TryParse(str, out choose))
            {
                Console.WriteLine("Phai chon 1, 2, 3, 4 hoac 5: ");
                str = Console.ReadLine();
            }
            process(choose);
        }
        private static void number1()
        {
            Console.Write("Nhap so luong xe: ");
            string str = Console.ReadLine();
            while (!uint.TryParse(str, out n))
            {
                Console.WriteLine("Nhap lai so luong xe: ");
                str = Console.ReadLine();
            }
            amount = n;
            Console.WriteLine("So luong xe o to da nhap: " + amount);
            Console.WriteLine();

            Bike bike;
            for (var i = 0; i < n; i++)
            {
                Console.Write($"Tao xe thu {i + 1}: ");
                bike = new Bike();
                Console.Write("Nhap Make: ");
                bike.Make = Console.ReadLine();
                Console.Write("Nhap Model: ");
                bike.Model = Console.ReadLine();
                Console.Write("Nhap Year: ");
                str = Console.ReadLine();
                while (!uint.TryParse(str, out n))
                {
                    Console.WriteLine("Nhap lai Year: ");
                    str = Console.ReadLine();
                }
                bike.Year = n;
                bikeList.Add(bike);
            }
        }

        private static void number2()
        {
            if (amount == 0)
            {
                Console.WriteLine("Chua co xe nao.");
            } 
            else
            {
                Console.WriteLine("Xe dap da nhap: ");
                foreach (var n in bikeList)
                {
                    n.ToString();
                }
            }
            
        }

        private static void number3()
        {
            Console.Write("Nhap so luong xe: ");
            string str = Console.ReadLine();
            while (!uint.TryParse(str, out n))
            {
                Console.WriteLine("Nhap lai so luong xe: ");
                str = Console.ReadLine();
            }
            amount = n;
            Console.WriteLine("So luong xe dap da nhap: " + amount);
            Console.WriteLine();

            Car car;
            for (var i = 0; i < amount; i++)
            {
                Console.Write($"Tao xe thu {i + 1}: ");
                car = new Car();
                Console.Write("Nhap Make: ");
                car.Make = Console.ReadLine();
                Console.Write("Nhap Model: ");
                car.Model = Console.ReadLine();
                Console.Write("Nhap Year: ");
                str = Console.ReadLine();
                while (!uint.TryParse(str, out n))
                {
                    Console.WriteLine("Nhap lai Year: ");
                    str = Console.ReadLine();
                }
                car.Year = n;

                Console.Write("Nhap Type: ");
                car.Type = Console.ReadLine();

                Console.Write("Nhap Speed: ");
                str = Console.ReadLine();
                while (!uint.TryParse(str, out n))
                {
                    Console.WriteLine("Nhap lai Speed: ");
                    str = Console.ReadLine();
                }
                car.Speed = n;
                carList.Add(car);
            }
        }
        private static void number4()
        {
            if (amount == 0)
            {
                Console.WriteLine("Chua co xe nao: ");
            }
            else
            {
                Console.WriteLine("Xe o to da nhap: ");
                foreach (var n in carList)
                {
                    n.ToString();
                }
            }
            
        }
    }
}
