using System;
using System.IO;

namespace ExerciseFileIO
{
    /* Bài 1
    * Tạo menu mảng HAI chiều:
    * 1. Tìm max của mảng
    * 2. Tìm min của mảng
    * 3. Tổng của mảng
    * 4. sắp xếp tăng dần
    * 5. Tìm kiếm phần tử n của mảng, trả về index
    */
    class Test2Array
    {
        static StreamWriter swW;
        static StreamReader swR;
        static int length;
        static int row;
        static int column;
        static string path = "text1.txt";
        static int[,] arrayNum;
        static string[] arr;
       static  int[] array;

        static void Main(string[] args)
        {
            Console.Write("Enter the Row of Array: ");
            string str = Console.ReadLine();

            //điền hàng
            while (!int.TryParse(str, out row) || row < 0 || row > 100)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            //điền cột 
            Console.Write("Enter the Column of Array: ");
            str = Console.ReadLine();

            while (!int.TryParse(str, out column) || column < 0 || column > 100)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }

            Random num = new Random();
            using (swW = new StreamWriter(path))
            {
                swW.WriteLine("Row: {0}\tColumn: {1} ", row, column);
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
                string[] lines = File.ReadAllLines(path);
                //Console.WriteLine("Number of lines: {0}", lines.Length);
                for (int i = 1; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                Console.WriteLine();
            }
            else if ("N".Equals(str))
            {
                Console.WriteLine("You didn't want to read it.");
            }
        
            CreateArray();
            //Console.WriteLine(arr.Length);
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\t\t\t*************************************");
            Console.WriteLine("\t\t\t*        MENU 1-ARRAY               *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Find max                   *");
            Console.WriteLine("\t\t\t*     2. Find min                   *");
            Console.WriteLine("\t\t\t*     3. Sum array                  *");
            Console.WriteLine("\t\t\t*     4. Sort >>                    *");
            Console.WriteLine("\t\t\t*     5. Enter element, find index  *");
            Console.WriteLine("\t\t\t*     6. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

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
                    //nsole.WriteLine("Array's max is: {0}", FindMax());
                    break;
                case 2:
                    //nsole.WriteLine("Array's min is: {0}", FindMin());
                    break;
                case 3:
                    //nsole.WriteLine("Array's sum element is: {0}", Sumarise());
                    break;
                case 4:
                   
                    break;
                case 5:
                    
                    break;
                case 6:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }

        static void CreateArray()
        {
            int[,] arrayNum = new int[row, column];
            using (swR = new StreamReader(path))
            {
                string line;
                string[] arr;

                string data = string.Empty;
                while ((data = swR.ReadLine()) != null)
                {
                    for (int i = 0; i < row; i++)
                    {
                        line = swR.ReadLine();
                        Console.WriteLine(line);
                        for (int j = 0; j < line.Length; j++)
                        {
                            arr = line.Split(" ");
                            array = Array.ConvertAll<string, int>(arr, Convert.ToInt32);
                        }
                       // Console.WriteLine(arr);
                        Console.WriteLine(array[0]);
                    }
                }
            }
            Console.WriteLine(arr.Length);
            
        }
        #region phần thân


        //static int FindMax()
        //{

        //}

        //static int FindMin()
        //{

        //}


        //static int Sumarise()
        //{

        //}

        //static int[] SortArray(int length)
        //{

        //}

        //static int FindElement()
        //{

        //}
        #endregion

    }
}
