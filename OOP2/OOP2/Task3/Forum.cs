using System;

namespace Task3
{
    public class Forum
    {
        static PostRepository PostRepo = new PostRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*       POST MANAGEMENT SYSTEM      *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Create Post                *");
            Console.WriteLine("\t\t\t*     2. Calculator                 *");
            Console.WriteLine("\t\t\t*     3. Show list                  *");
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
                    Console.WriteLine("Create Post....\n");
                    PostRepo.CreatePost();
                    Console.WriteLine("Create Post finish...");
                    break;
                case 2:
                    Console.WriteLine("Calculate Rate....\n");
                    PostRepo.Calculator();
                    Console.WriteLine("Calculate Rate finish ....");
                    break;
                case 3:
                    Console.WriteLine("Show Post List....\n");
                    PostRepo.ShowList();
                    Console.WriteLine("Show Post List finish...");
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
