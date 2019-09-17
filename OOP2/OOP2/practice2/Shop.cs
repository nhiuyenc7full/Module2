using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace practice2_1
{
    class Shop
    {
        private static List<Product> productList = new List<Product>();

        static int upPrice;
        static int lowPrice;
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void RemoveProduct(string nameInput)
        {
            //foreach (var item in productlist)
            //{
            //    if (item.name == nameinput)
            //    {
            //        productlist.remove(item);
            //        break;
            //    }
            //}

            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].Name == nameInput)
                {
                    productList.RemoveAt(i);
                }
            }
        }
        public void IterateProductList()
        {
            
            foreach (var item in productList)
            {
                Console.WriteLine(item.ViewInfor());
            }
        }
        public void SearchProduct(int price1, int price2)
        {

            if (price1 > price2)
            {
                upPrice = price1;
                lowPrice = price2;
            }
            else if (price2 > price1)
            {
                upPrice = price2;
                lowPrice = price1;
            }

            foreach (var item in productList)
            {
                if (item.Price > lowPrice && item.Price < upPrice)
                {
                    item.ViewInfor();
                }
            }
        }
        public void ExportFile()
        {
            foreach (var item in productList)
            {
                string path = item.Name + ".txt";
                using(StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine(item.ViewInfor());
                }
            }
        }
        public void SearchProductEdit()
        {
            Console.Write("Enter name of product you want to edit: ");
            string str = Console.ReadLine();
            //foreach (Product item in productList)
            //{
            //    if (str.Equals(item.Name))
            //    {
            //        item.ViewInfor();
            //        EditProduct(item);
            //        productList.Add(item);
            //    }
            //}
            for (int i = 0; i < productList.Count; i++)
            {
                if (str.Equals(productList[i].Name))
                {
                    EditProduct(productList[i]);
                }
            }
        }

        public void EditProduct(Product item)
        {
            Console.WriteLine("What do you want to change? Choose price (press 1) or decription (press 2).");
            string str = Console.ReadLine();
            int editChoose;
            while(!int.TryParse(str, out editChoose) || editChoose < 1 || editChoose > 3)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            switch (editChoose)
            {
                case 1:
                    Console.Write("Enter price: ");
                    str = Console.ReadLine();
                    int price;
                    while (!int.TryParse(str, out price))
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    item.Price = price;
                    break;
                case 2:
                    Console.Write("Enter decription: ");
                    string decription = Console.ReadLine();
                    item.Decription = decription;
                    break;

            }
        }

    }
}
