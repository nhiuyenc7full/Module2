using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5_2
{

    public class BookRepository
    {
        public List<int> priceList = new List<int>();
        public List<Book> bookList = new List<Book>();
        public void CreateBook()
        {
            Console.Write("Enter name of book: ");
            string name = Console.ReadLine();
            Console.Write("Enter publish date of book: ");
            string str = Console.ReadLine();
            DateTime publishDate;
            while(!DateTime.TryParse(str, out publishDate))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter author of book: ");
            string author = Console.ReadLine();
            Console.Write("Enter language of book: ");
            string language = Console.ReadLine();


            Console.WriteLine("Enter 5 price of this book: ");
            int count = 0;
            do
            {
                int price = CheckPriceInt(Console.ReadLine());
                priceList.Add(price);
                count++;
            }
            while (count != 5);
            Book book = new Book(name, publishDate, author, language, priceList);
            bookList.Add(book);
        }

        private int CheckPriceInt(string str)
        {
            int price;
            while(!int.TryParse(str, out price) || price < 0)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return price;
        }

        public void ViewBookList()
        {
            foreach (var item in bookList)
            {
                item.Display();
            }
        }

    }
}
