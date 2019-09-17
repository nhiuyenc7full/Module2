using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExerciseFileIO
{
    /*Bài 2
    * Tạo menu mảng HAI chiều:
    * 1. Tìm max của mảng
    * 2. Tìm min của mảng
    * 3. Tổng của mảng
    * 4. sắp xếp tăng dần tất cả
    * 5. Tìm kiếm phần tử index n của mảng
    */
    class bai2
    {
        static int row, column;
        static StreamWriter swW;
        static StreamReader swR;
        static string path = "bai2.txt";
        static int[,] arrayNum = new int[row, column];
        static string str;
        static void Main()
        {

            Console.Write("Enter the number of row: ");
            str = Console.ReadLine();
            row = checkNum(str);
            Console.Write("Enter the number of column:");
            str = Console.ReadLine();
            column = checkNum(str);

            Random num = new Random();
            using (swW = new StreamWriter(path, true)) ///append: true: cho ghi file; false: k cho ghi tiếp
            {
                //swW.WriteLine("The row: {0}; the column: {1}", row, column);
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        swW.Write(num.Next(1, 100) + " ");
                    }
                    swW.WriteLine();
                }
            }

            Console.WriteLine("Do you want to read? press Y/N: ");
            str = Console.ReadLine();

            if ("Y".Equals(str))
            {
                string data = String.Empty;
                using (swR = new StreamReader(path))
                {
                    while ((data = swR.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }

                }
            }
            else if ("N".Equals(str))
            {
                Console.WriteLine("You didn't want to read it.");
            }
            arrayNum = CreateArray();
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\t\t\t*************************************");
            Console.WriteLine("\t\t\t*        MENU 2-ARRAY               *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Find max                   *");
            Console.WriteLine("\t\t\t*     2. Find min                   *");
            Console.WriteLine("\t\t\t*     3. Sum array                  *");
            Console.WriteLine("\t\t\t*     4. Sort >>                    *");
            Console.WriteLine("\t\t\t*     5. Enter element, find index  *");
            Console.WriteLine("\t\t\t*     6. Exit                       *");
            Console.WriteLine("\t\t\t*************************************\n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, 4, 5, or 6");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 7)
            {
                Console.WriteLine("Enter again! Choose 1, 2, 3, 4, 5, or 6! ");
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
                        Console.WriteLine("Array's max is: {0}", FindMax());
                        break;
                    case 2:
                        Console.WriteLine("Array's min is: {0}", FindMin());
                        break;
                    case 3:
                        Console.WriteLine("Array's sum element is: {0}", Sumarise());
                        break;
                    case 4:
                        SortArray();

                        using (swW = new StreamWriter(path))
                        {
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < column; j++)
                                {
                                    swW.Write(arrayNum[i, j] + " ");
                                }
                            swW.WriteLine();
                            }
                        }
                        Console.WriteLine("Your array is re-sorted!");
                        break;
                    case 5:
                        string index = FindElement();
                        if (index == " ")
                        {
                            Console.WriteLine("Not found!");
                        }
                        else Console.WriteLine("The index of element you searched is: {0}", index);
                        break;
                    case 6:
                        Console.WriteLine("Exit the program.");
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
                DisplayMenu();
            }

        static int[,] CreateArray()
        {
            int[,] array = new int[row, column];
            using (swR = new StreamReader(path))
            {
                string data = String.Empty;
                for (int i = 0; i < row; i++)
                {
                    if ((data = swR.ReadLine()) != null)
                    {
                        string[] stringNum = data.Trim().Split(" ");
                        for (int j = 0; j < column; j++)
                        {
                            array[i, j] = int.Parse(stringNum[j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            return array;
        }

        static int FindMax()
        {
            int max = arrayNum[0, 0];
            foreach (var item in arrayNum)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        static int FindMin()
        {
            int min = arrayNum[0, 0];
            foreach (var item in arrayNum)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }


        static int Sumarise()
        {
            int sum = 0;
            foreach (var element in arrayNum)
            {
                sum += element;
            }
            return sum;
        }

        static int[,] SortArray()
        {
            int length = row * column;
            int[] array = new int[length];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i * column + j] = arrayNum[i, j];
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j > i; j--)
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arrayNum[i, j] = array[i * column + j];
                }
            }

            return arrayNum;
        }

        static string FindElement()
        {
            Console.Write("Input the number you want to find: ");
            string str = Console.ReadLine();
            int number;
            while (!int.TryParse(str, out number))
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (number == arrayNum[i, j])
                    {
                        return $"Row: {i}; Column: {j}.";
                    }
                }
            }
            return " ";
        }
        static int checkNum(string str)
        {
            int num;
            while (!int.TryParse(str, out num) || num <= 0)
            {
                Console.Write("Enter again: ");
                str = Console.ReadLine();
            }
            return num;
        }

    }


}
