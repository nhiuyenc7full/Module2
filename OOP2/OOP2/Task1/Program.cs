using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            int[,] array = InitMatrix();
            Console.WriteLine("Init succeeded.....\n");

            Console.WriteLine("Enter row you want to get sum: ");
            int row = CheckInt(Console.ReadLine());
            while(row >= array.GetLength(0) || row < 0)
            {
                Console.WriteLine("Enter again! ");
                row = CheckInt(Console.ReadLine());
            }
            Console.WriteLine("Sum row {0} is {1}\n", row, SumAArray(array, row));

            Console.WriteLine(ShowMaxRow(array));

        }

        static int[,] InitMatrix()
        {
            Console.WriteLine("Create Matrix...\n");
            Console.Write("Enter number of row: ");
            int n = CheckIntInitMatrix(Console.ReadLine());
            Console.Write("Enter number of column: ");
            int m = CheckIntInitMatrix(Console.ReadLine());

            int[,] array = new int[n, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = CheckInt(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return array;
        }

        static int SumAArray(int[,] array, int row)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[row, j];
            }

            return sum;
        }

        static string ShowMaxRow(int[,] array)
        {

            int rowSum = 0;
            //Cho các sum vào một mảng 1 chiều
            int[] sumArray = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowSum += array[i, j];
                }
                sumArray[i] = rowSum;
                rowSum = 0;
            }
            //Lấy chỉ số của phần tử lớn nhất trong mảng 1 chiều >> row sum max
            int maxIndex = 0;
            int maxSum = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                if(sumArray[i] > maxSum)
                {
                    maxSum = sumArray[i];
                    maxIndex = i;
                }
            }
            string data = String.Empty;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                data += array[maxIndex, j] + " ";
            }
            Console.WriteLine();
            return $"Max sum row is {maxIndex}, it element is {data}";
        }

        static int CheckIntInitMatrix(string str)
        {
            int number;
            while(!int.TryParse(str, out number) || number < 1)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return number;
        }

        static int CheckInt(string str)
        {
            int number;
            while (!int.TryParse(str, out number))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return number;
        }
    }
}
