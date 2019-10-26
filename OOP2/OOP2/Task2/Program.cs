using System;

namespace Task2
{
    public class Program
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
            Console.WriteLine("\t\t\t*           2. Check increase       *");
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
                    break;
                case 2:
                    if (IsIncreaseArray())
                    {
                        Console.WriteLine("Array is an increasing array.");
                    } 
                    else
                    {
                        Console.WriteLine("Array is not an increasing array.");
                    }
                    break;
                case 3:
                    SelectedSort(array);
                    Console.WriteLine("Sorted! ");
                    break;
                case 4:
                    Find();
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
            while(!int.TryParse(str, out length) || length < 0)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            return array;
        }

        static bool IsIncreaseArray()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
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

        static void Find()
        {
            if (IsIncreaseArray())
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
                if(index != -1)
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
    }
}
