using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExerciseArray
{
    class Check
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
            }
            sw.Stop();
            Console.WriteLine("Parse pattern took {0}ticks", sw.ElapsedTicks);
            sw.Reset();

            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
            }
            sw.Stop();
            Console.WriteLine("Parse pattern took {0}ticks", sw.ElapsedTicks);
            sw.Reset();
        }
    }
    class Program
    {
        const int LENGTH = 100;
        static int[] array = new int[LENGTH];
        static List<int> list = new List<int>(LENGTH);
        static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch st = new Stopwatch();

            st.Start();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 5);
            }
            st.Stop();
            Console.WriteLine($"Time create an Array is: {st.Elapsed.ToString()}\n");
            st.Reset();


            //st.Start();
            //for (int i = 0; i < 10000; i++)
            //{
            //    list.Add(random.Next(1, 100));
            //}
            //st.Stop();
            //Console.WriteLine($"Time create an List is: {st.Elapsed.ToString()}\n");
            //st.Reset();

            //SortList();

            //SortArray();

            //FindElementList();

            FindElementArray();

            //DeleteElementList();

            //DeleteElementArray();
        }

        static void SortList()
        {
            Stopwatch st = new Stopwatch();
            Console.WriteLine("Order the List: ");
            st.Start();
            int tmp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            st.Stop();
            Console.WriteLine("\nTime to order List: {0}\n", st.Elapsed.ToString());
        }

        static void SortArray()
        {
            Stopwatch st = new Stopwatch();
            Console.WriteLine("Order the Array: ");
            st.Start();
            int tmp;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            st.Stop();
            Console.WriteLine("\nTime to order Array: {0}\n", st.Elapsed.ToString());
        }

        static void FindElementList()
        {
            Console.WriteLine("\nFind element in List: ");
            int number = int.Parse(Console.ReadLine());
            int index = list.IndexOf(number);
            Console.WriteLine("\nFound at {0}", index);
        }

        static void FindElementArray()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            int number;
            Console.WriteLine("\nFind element in Array: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    Console.WriteLine("\nFound at {0}", i);
                    return;
                }
            }
            Console.WriteLine("Not found!");
        }

        static void DeleteElementArray()
        {
            Stopwatch st = new Stopwatch();
            Console.Write("Delete element by index in array: ");
            int index = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length - 1];
            st.Start();
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
            st.Stop();
            Console.WriteLine("\nDeleted this element...\n");
            Console.WriteLine("Time to delete Array: {0}\n", st.Elapsed.ToString());
        }

        static void DeleteElementList()
        {
            Stopwatch st = new Stopwatch();
            Console.WriteLine("\nDelete element by index in list: ");
            int index = int.Parse(Console.ReadLine());
            st.Start();
            list.Remove(list[index]);
            st.Stop();
            Console.WriteLine("\nDeleted this element...\n");
            Console.WriteLine("Time to order List: {0}", st.Elapsed.ToString());
        }
    }
    class ArrayDo
    {
        const int LENG = 50;
        static Stopwatch time = new Stopwatch();
        static void Main()
        {

            ArrayList arrList = CreateArrayList();
            List<int> list = CreateList();

            FindElementAL(arrList);
            FindElementL(list);

            EditElementAL(arrList);
            EditElementL(list);

            DeleteElementAL(arrList);
            DeleteElementL(list);
        }


        static ArrayList CreateArrayList()
        {
            Random random = new Random();
            ArrayList arrList = new ArrayList();
            time.Start();
            for (int i = 0; i < LENG; i++)
            {
                arrList.Add(random.Next(1, 5));
            }
            time.Stop();
            Console.WriteLine("Create array list succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            return arrList;
        }
        static void FindElementAL(ArrayList arrList)
        {
            Console.Write("\nEnter element to find: (AL) ");
            int element = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < arrList.Count; i++)
            {
                int found = (int)arrList[i];
                if (found == element)
                {
                    Console.WriteLine("Found at: {0}", i);
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine("Find complete...");
        }
        static void EditElementAL(ArrayList arrList)
        {
            Console.Write("\nEnter element want to edit: (AL) ");
            int oldElement = int.Parse(Console.ReadLine());
            Console.Write("Enter new element: ");
            int newElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Before edit: ");
            foreach (var item in arrList)
            {
                Console.Write(item + " ");
            }
            bool check = false;
            time.Start();
            for (int i = 0; i < arrList.Count; i++)
            {
                int found = (int) arrList[i];
                if (found == oldElement)
                {
                    arrList[i] = newElement;
                    check = true;
                }
            }
            time.Stop();
            Console.WriteLine("\nEdit succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            if (!check)
            {
                Console.WriteLine("Not found.");
            }
            Console.WriteLine("\nAfter edit: ");
            foreach (var item in arrList)
            {
                Console.Write( item + " ");
            }
        }
        static void DeleteElementAL(ArrayList arrList)
        {
            Console.Write("\nEnter element you want to delete: (AL) ");
            int element = int.Parse(Console.ReadLine());
            time.Start();
            for (int i = 0; i < arrList.Count; i++)
            {
                if ((int)arrList[i] == element)
                {
                    arrList.RemoveAt(i);
                }
            }
            time.Stop();
            Console.WriteLine("Delete succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            Console.WriteLine("\nAfter delete: ");
            foreach (var item in arrList)
            {
                Console.Write(item + " ");
            }
        }
        static List<int> CreateList()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            time.Start();
            for (int i = 0; i < LENG; i++)
            {
                list.Add(random.Next(1, 5));
            }
            time.Stop();
            Console.WriteLine("Create list succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            return list;
        }
        static void FindElementL(List<int> list)
        {
            Console.Write("Enter element to find: (L) ");
            int element = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < list.Count; i++)
            {
                int found = list[i];
                if (found == element)
                {
                    Console.WriteLine("Found at: {0}", i);
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine("Find complete...");
        }
        static void DeleteElementL(List<int> list)
        {
            Console.Write("\nEnter element you want to delete: (L) ");
            int element = int.Parse(Console.ReadLine());
            time.Start();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == element)
                {
                    list.RemoveAt(i);
                }
            }
            time.Stop();
            Console.WriteLine("Delete succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            Console.WriteLine("\nAfter delete: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
        static void EditElementL(List<int> list)
        {
            Console.Write("Enter element want to edit: (L) ");
            int oldElement = int.Parse(Console.ReadLine());
            Console.Write("Enter new element: ");
            int newElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Before edit: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            bool check = false;
            time.Start();
            for (int i = 0; i < list.Count; i++)
            {
                int found = list[i];
                if (found == oldElement)
                {
                    list[i] = newElement;
                    check = true;
                }
            }
            time.Stop();
            Console.WriteLine("\nEdit succeeded, time: {0} ticks", time.ElapsedTicks);
            time.Reset();
            if (!check)
            {
                Console.WriteLine("Not found.");
            }
            Console.WriteLine("\nAfter edit: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }

    }
}
