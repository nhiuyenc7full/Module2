using System;

namespace Bai2
{
    class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*                ARRAY              *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*           1. Create array         *");
            Console.WriteLine("\t\t\t*           2. Check Symmetry array *");
            Console.WriteLine("\t\t\t*           3. Sort array           *");
            Console.WriteLine("\t\t\t*           4. Find element         *");
            Console.WriteLine("\t\t\t*           5. Exit                 *");
            Console.WriteLine("\t\t\t*************************************\n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, 4 or 5");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 5)
            {
                Console.WriteLine("Enter again! Choose 1, 2, 3, 4 or 5! ");
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
                    array = InitArray();
                    Console.WriteLine("Create finished....");
                    break;
                case 2:
                    if (IsSymmetryArray(array))
                    {
                        Console.WriteLine("Array is an symmetry array.");
                    }
                    else
                    {
                        Console.WriteLine("Array is not an symmetry array.");
                    }
                    Console.Write("Array: ");
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 3:
                    BubbleSort(array);
                    Console.WriteLine("Sorted! ");

                    Console.Write("New array: ");
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 4:
                    Find();
                    Console.WriteLine("Array: ");
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }

        static int[] InitArray()
        {
            Console.Write("Enter length of array: ");
            string str = Console.ReadLine();
            int length;
            while (!int.TryParse(str, out length) || length < 0)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);
            }
            return array;
        }

        static bool IsSymmetryArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j++)
                {
                    if (array[i] != array[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void BubbleSort(int[] array)
        {
            int tmp;
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tmp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = tmp;
                    }
                }
            }
        }

        static void Find()
        {
            if (IsIncreasingArray())
            {
                Console.Write("Enter element you want to find: ");
                string str = Console.ReadLine();
                int element;
                while (!int.TryParse(str, out element))
                {
                    Console.Write("Enter again! ");
                    str = Console.ReadLine();
                }
                int index = BinarySearch(array, 0, array.Length, element);
                if (index != -1)
                {
                    Console.WriteLine($"{element} is found at {index}");
                }
                else
                {
                    Console.WriteLine("Not found the element.");
                }
            }
            else
            {
                Console.WriteLine("You need to sort the array first!");
            }
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

        static bool IsIncreasingArray()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }
    }
}
