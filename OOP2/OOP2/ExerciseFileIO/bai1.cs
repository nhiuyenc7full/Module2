using System;
using System.IO;

namespace ExerciseFileIO
{
                                    /* Bài 1
                                    * Tạo menu mảng MỘT chiều:
                                    * 1. Tìm max của mảng
                                    * 2. Tìm min của mảng
                                    * 3. Tổng của mảng
                                    * 4. sắp xếp tăng dần
                                    * 5. Tìm kiếm phần tử n của mảng, trả về index
                                    */
    class bai1
    {
        static StreamWriter swW;
        static StreamReader swR;
        static int length;
        static string path = "text.txt";
        static int[] arrayNum;

        static void Main(string[] args)
        {
            
            Console.Write("Enter the Length of Array: ");
            string str = Console.ReadLine();
            
            while (!int.TryParse(str, out length) || length < 0 || length > 100)
            {
                Console.WriteLine("Enter again!");
                str = Console.ReadLine();
            }
            Random num = new Random();
            using(swW = new StreamWriter(path))
            {
                swW.WriteLine("Length: " + length);
                for (int i = 0; i < length; i++)
                {
                    swW.WriteLine(num.Next(1, 100));
                }
            }
            arrayNum = CreateArray();
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
                    if(arrayNum.Length>0)
                    {
                    Console.WriteLine("Array's max is: {0}", FindMax());
                    }
                    else
                    {
                        Console.WriteLine("Array has no element.");
                    }
                    break;
                case 2:
                    if (arrayNum.Length > 0)
                    {
                        Console.WriteLine("Array's min is: {0}", FindMin());
                    }
                    else
                    {
                        Console.WriteLine("Array has no element.");
                    }
                    break;
                case 3:
                    if (arrayNum.Length > 0)
                    {
                        Console.WriteLine("Array's sum element is: {0}", Sumarise());
                    }
                    else
                    {
                        Console.WriteLine("Array has no element.");
                    }
                    break;
                case 4:
                    if (arrayNum.Length > 0)
                    {
                        for (int i = 0; i < arrayNum.Length; i++)
                        {
                            Console.WriteLine(arrayNum[i] + " ");
                        }
                        arrayNum = SortArray(length);
                        using (swW = new StreamWriter(path))
                        {
                            swW.WriteLine("Length: " + length);
                            for (int i = 0; i < length; i++)
                            {
                                swW.Write(arrayNum[i] + " ");
                            }
                        }
                        Console.WriteLine("Your array is re-sorted!");
                        for (int i = 0; i < arrayNum.Length; i++)
                        {
                            Console.WriteLine(arrayNum[i] + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Array has no element.");
                    }

                    break;
                case 5:
                    Console.Write("Input the number you want to find: ");
                    string str = Console.ReadLine();
                    int number;
                    while (!int.TryParse(str, out number))
                    {
                        Console.WriteLine("Enter again!");
                        str = Console.ReadLine();
                    }
                    if (arrayNum.Length > 0)
                    {
                        //int index = FindElement(number);
                        int index = BinarySearch(arrayNum, 0, arrayNum.Length - 1, number);
                        if (index == -1)
                        {
                            Console.WriteLine("Not found!");
                        }
                        else Console.WriteLine("The index of element you searched is: {0}", index);
                    }
                    else
                    {
                        Console.WriteLine("Array has no element.");
                    }

                    break;
                case 6:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }

        static int[] CreateArray()
        {
            int[] arrayNum = new int[length];
            using (swR = new StreamReader(path))
            {
                string data = string.Empty;
                if ((data = swR.ReadLine()) != null || arrayNum.Length == 0)
                {
                    for (int i = 0; i < arrayNum.Length; i++)
                    {
                        arrayNum[i] = Convert.ToInt32(swR.ReadLine());
                    }
                }
                else Console.WriteLine("No lines to read.");
            }
            return arrayNum;
        }

        static int FindMax()
        {
            int max = arrayNum[0];
            for (int i = 1; i < length; i++)
            {
                max = Math.Max(max, arrayNum[i]);
            }
            return max;
        }

        static int FindMin()
        {

            int min = arrayNum[0];
            for (int i = 1; i < length; i++)
            {
                min = Math.Min(min, arrayNum[i]);
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

        static int[] SortArray(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j > i; j--)
                    if (arrayNum[j] < arrayNum[j - 1])
                    {
                        int temp = arrayNum[j];
                        arrayNum[j] = arrayNum[j - 1];
                        arrayNum[j - 1] = temp;
                    }
            }
            return arrayNum;
        }

        static int BinarySearch(int[] array, int left, int right, int element)
        {
            
            if (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == element)
                {
                    return mid;
                }
                if (array[mid] > element)
                {
                    return BinarySearch(array, left, mid - 1, element);
                }
                return BinarySearch(array, mid + 1, right, element);
            }
            return -1;
        }

        static void SelectedSort(int[] array)
        {
            int index;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[index] > array[j])
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }
        }
        
        static int FindElement(int element)
        {
            for (int i = 0; i < length; i++)
            {
                if (element == arrayNum[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
