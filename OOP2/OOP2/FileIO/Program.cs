using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        #region streamswriter
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Create a new file: ");

        //    WriteToFile("text.txt");

        //}

        //private static void WriteToFile(string path)
        //{
        //    StreamWriter f = new StreamWriter(path);
        //    Random random = new Random();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        f.WriteLine(random.Next(1, 100));
        //    }
        //    f.Close();
        //}
        #endregion

        // streamwriter nhập vào một số là chiều dài của mảng, sau đó nhập vào từng phần tử của mảng vào file.
        //Viết trên một dòng cách nhau bằng dấu _.


        /*Bài 2
         * Tạo menu mảng HAI chiều:
         * 1. Tìm max của mảng
         * 2. Tìm min của mảng
         * 3. Tổng của mảng
         * 4. sắp xếp tăng dần tất cả
         * 5. Tìm kiếm phần tử index n của mảng
         */

        /*Bài 3
         * 6. product. bổ sung menu cuối cũng là ghi file
         * (tên file phải là id)
         * 7. Tìm kiếm và chỉnh sửa dựa trên tên file
         */

        /*Bài 4 giống bài 3, làm animal
         */

        static void Main()
        {
            WriteToFile("number.txt");
            findMax("number.txt");
        }

        private static void findMax(string path)
        {
            StreamReader fR = new StreamReader(path);

        }

        private static void WriteToFile(string path)
        {
            StreamWriter fW = new StreamWriter(path);

            Console.Write("Enter the Length of the Array: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] array = new int[length];

            Random random = new Random();
            fW.WriteLine("The Length of the Array: " + length);
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 10);
                fW.Write(array[i] + " ");
            }
            fW.Close();
        }


    }

}
