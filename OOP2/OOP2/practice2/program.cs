using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_1
{
    class program
    {   
        private static Shop shop;
        private static Product product;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM:");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\n***********************************");

            int choose;
            string str = Console.ReadLine();
            while(!int.TryParse(str, out choose))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Process(choose);
        }
        static void Process(int choose)
        {
            shop = new Shop();
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the information of product: ");

                        Console.Write("Enter Product's name: ");
                        string _name = Console.ReadLine();

                        Console.Write("Enter Product's description: ");
                        string _description = Console.ReadLine();

                        Console.Write("Enter Product's price: ");
                        string str = Console.ReadLine();
                        double _price;
                        while (!double.TryParse(str, out _price) || _price > 100 || _price < 0)
                        {
                            Console.WriteLine("Enter again!");
                            str = Console.ReadLine();
                        }

                        product = new Product(_name, _description, _price);
                        Console.Write("\nThe information of product added: ");
                        product.ViewInfor();

                        shop.AddProduct(product);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter the name of product you want to remove: ");
                        string nameInput = Console.ReadLine();
                        shop.RemoveProduct(nameInput);
                    }
                    break;
                case 3:
                    {
                        shop.IterateProductList();
                    }
                    break;

                case 4:
                    {
                        Console.Write("Enter the price 1: ");
                        string str = Console.ReadLine();
                        int price1;
                        while (!int.TryParse(str, out price1) || price1 > 100 || price1 < 0)
                        {
                            Console.WriteLine("Enter again!");
                            str = Console.ReadLine();
                        }

                        Console.Write("Enter the price 2: ");
                        str = Console.ReadLine();
                        int price2;
                        while (!int.TryParse(str, out price2) || price2 > 100 || price2 < 0)
                        {
                            Console.WriteLine("Enter again!");
                            str = Console.ReadLine();
                        }

                        shop.SearchProduct(price1, price2);
                    }
                    break;
                case 5:
                    Console.WriteLine("Exit.");
                    Environment.Exit(Environment.ExitCode);
                    break;
                default:
                    Console.WriteLine("Enter 1, 2, 3, 4 or 5: ");
                    Menu();
                    break;
            }
            Menu();
        }
    }
}
