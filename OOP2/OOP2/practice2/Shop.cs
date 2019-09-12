using System;
using System.Collections.Generic;
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
                item.ViewInfor();
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
    }
}
