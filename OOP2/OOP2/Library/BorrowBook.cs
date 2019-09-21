using System;
using System.Collections;

namespace BorrowBook
{
    public class Book
    {
        private int numberBorrowBook;
        private string typeBorrowBook;
        private double money;
        private int dateBorrowAmount;

        public int NumberBorrowBook { get => numberBorrowBook; set => numberBorrowBook = value; }
        public string TypeBorrowBook { get => typeBorrowBook; set => typeBorrowBook = value; }
        public double Money { get => money; set => money = value; }
        
        public int DateBorrowAmount { get => dateBorrowAmount; set => dateBorrowAmount = value; }

        public Book()
        {

        }

        BookRepository bookRepo = new BookRepository();
        public void AcceptDetails()
        {
            Console.Write("Enter number of borrow book: ");
            string str = Console.ReadLine();
            int numberBook;
            while(!int.TryParse(str, out numberBook) || numberBook <= 0)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            NumberBorrowBook = numberBook;
            Console.Write("Enter amount day borrow: ");
            str = Console.ReadLine();
            int amountDay;
            while (!int.TryParse(str, out amountDay) || amountDay <= 0 || amountDay > 31)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            DateBorrowAmount = amountDay;
            Money = CalculateAmount();
;        }

        public double CalculateAmount()
        {
            bookRepo.EnterBookLibrary();   
            int rate = (int) bookRepo.TypeBook[TypeBorrowBook];
            double money = NumberBorrowBook * rate * DateBorrowAmount * 10 / 100;
            return money;
        }

    }
}
