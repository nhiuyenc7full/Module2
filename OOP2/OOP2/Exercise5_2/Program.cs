using System;

namespace Exercise5_2
{

    class Program
    {
        static BookRepository BookRepo = new BookRepository();
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*       BOOKS MANAGEMENT SYSTEM     *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Insert new book            *");
            Console.WriteLine("\t\t\t*     2. View list of students      *");
            Console.WriteLine("\t\t\t*     3. Average price              *");
            Console.WriteLine("\t\t\t*     4. Exit                       *");
            Console.WriteLine("\t\t\t*************************************\n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3 or 4");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 4)
            {
                Console.WriteLine("Enter again! Choose 1, 2, 3 or 4! ");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }

        static void ChooseMenu(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    BookRepo.CreateBook();
                    break;
                case 2:
                    BookRepo.ViewBookList();
                    break;
                case 3:
                    foreach (var item in BookRepo.bookList)
                    {
                        Console.WriteLine(item.AveragePrice);
                    }
                    break;
                case 4:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }
    }
}
