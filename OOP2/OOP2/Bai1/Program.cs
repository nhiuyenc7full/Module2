using System;

namespace Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            Console.WriteLine("Create Matrix...\n");
            Console.Write("Enter number of row: ");
            int n = CheckIntInitMatrix(Console.ReadLine());
            Console.Write("Enter number of column: ");
            int m = CheckIntInitMatrix(Console.ReadLine());

            int[,] array = new int[n, m];

            InitMatrix(array);
            Console.WriteLine("Init succeeded.....\n");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Max of the matrix is {0}", FindMax(array));

            Console.WriteLine("--------------------------");
            Console.WriteLine("Ma tran tam giac: ");
            ShowMatrix(array);
            Console.WriteLine("--------------------------");
        }

        static void InitMatrix(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 50);
                }
            }
        }

        static int FindMax(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        static void ShowMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int CheckIntInitMatrix(string str)
        {
            int number;
            while (!int.TryParse(str, out number) || number < 1)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return number;
        }

    }
}
