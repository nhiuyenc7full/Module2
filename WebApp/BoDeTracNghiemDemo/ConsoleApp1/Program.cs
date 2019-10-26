using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random 4 câu hỏi trong nhiều câu hỏi thuộc List
            //Random câu trả lời tương tự
            List<int> arr1 = new List<int>{1, 2, 3, 555,5,6,5,67,76,97,56,45,778798976,545,6,54};
            List<int> arr2 = new List<int>();
            int i = 0;
            var rd = new Random();

            while (i < 4)
            {
                int a = rd.Next(0, arr1.Count);
                arr2.Add(arr1[a]);
                arr1.Remove(arr1[a]);
                i++;
            }

            for (int j = 0; j < arr2.Count; j++)
            {
                Console.WriteLine(arr2[j]);
            }
            Console.ReadLine();
            
        }
    }
}
