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
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t************************************");
            Console.WriteLine("\t\t*    PRODUCT MANAGEMENT SYSTEM:    *");
            Console.WriteLine("\t\t*     1. Add new product           *");
            Console.WriteLine("\t\t*     2. Remove product            *");
            Console.WriteLine("\t\t*     3. Iterate product list      *");
            Console.WriteLine("\t\t*     4. Search product            *");
            Console.WriteLine("\t\t*     5. Export file               *");
            Console.WriteLine("\t\t*     6. Exit                      *");
            Console.WriteLine("\t\t************************************\n");

            int choose;
            string str = Console.ReadLine();
            while(!int.TryParse(str, out choose) || choose < 1 || choose > 6)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }
        static void ChooseMenu(int choose)
        {
            shop = new Shop();
            Console.Clear();
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
                        Console.Write("\nThe information of product was added: ");
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
                    shop.ExportFile();
                    Console.WriteLine("File was exported.");
                    break;
                case 6:
                    Console.WriteLine("Exit.");
                    Environment.Exit(Environment.ExitCode);
                    break;

            }
            DisplayMenu();
        }
    }
}
