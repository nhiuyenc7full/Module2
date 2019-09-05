using System;
using System.Collections.Generic;
using System.IO; //dùng File.Info phải có system.IO

namespace ConsoleApp1
{
    class _29
    //Có một file test1.txt trong thư mục. 
    //Nếu file tồn tại, in ra length của file, xóa file.
    //Nếu file k tồn tại, in ra "không tồn tại".

    //Đổi tên file teste.txt thành tên do người dùng nhập vào.
    {
        static void Main()
        {
            //FileInfo f = new FileInfo("test1.txt");
            string f1 = "test1.txt";
            string f2 = "test2.txt";
            Console.WriteLine("File's length: " + f1.Length.ToString()); //chiều dài của file chính là size của file

            if (File.Exists(f1))
            {
                Console.WriteLine("File exists");
                Console.WriteLine("Delele file");
                File.Delete(f1);
                if (!File.Exists(f1))
                {
                    Console.WriteLine("File deleted.");
                }
            }
            else
            {
                Console.WriteLine($"File {0} doesn't exist", f1);
            }

            if (File.Exists(f2))
            {
                Console.WriteLine("Enter the new name for the File: ");
                string newFile = Console.ReadLine();

                while (newFile == "")
                {
                    newFile = Console.ReadLine();
                }
                File.Move(f2, newFile);

                if (File.Exists(newFile))
                {
                Console.WriteLine("File is renamed successfully.");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist.");
            }

            
            Console.ReadKey();

        }
    }
}
