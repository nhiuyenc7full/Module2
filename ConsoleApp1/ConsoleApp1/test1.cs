using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class test1 //cho người dùng nhập vào n chỉ số dòng và m chỉ số cột để tạo mảng hai chiều. 
        //tính tổng các phần tử của mảng 2 chiều
    {
        static void Main()
        {
            Console.WriteLine("Nhap dong: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cot: ");
            var m = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, m];
            var sum = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.WriteLine($"nhap phan tu array[{i}, {j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Tong cac phan tu là: " + sum);
        }

    }
}
