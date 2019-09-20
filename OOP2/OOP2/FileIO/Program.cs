using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class Program
    {
        #region đơn giản
        //static void Main()
        //{
        //    string str = "uyen";
        //    string str1 = "uyen1";
        //    string[] str2 = new string[] { "uyen", "lan" };
        //    string[] stringg = { "uyen", "lan", "hoa" };
        //    string file = @"D:/pokemon/uyen.txt";
        //    string file1 = @"D:/pokemon/uyen1.txt";
        //    string[] createText = { "Nhị Uyên", "And", "Welcome" };
        //    File.WriteAllText(file1, str1);
        //    if (!File.Exists(file))
        //    {
        //        File.WriteAllLines(file, createText, Encoding.UTF8);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Empty");
        //    }

        //}
        #endregion

        #region level 1: đọc file từ @"D:\pokemon\1000.txt"
        //static void Main()
        //{
        //    string path = @"D:\pokemon\1000.txt";
        //    string data = String.Empty;
        //    try
        //    {
        //        using(StreamReader rFile = new StreamReader(path))
        //        {
        //            while ((data = rFile.ReadLine()) != null)
        //            {
        //                Console.WriteLine(data);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Can not read file.");
        //        Console.WriteLine(e.Message);
        //    }
        //}
        #endregion

        #region level 2: dùng append để ghi tiếp vào file sẵn có, Environment.NewLine
        //static void Main()
        //{
        ////file "WriteLines.txt" được lưu ở thư mục Dell/Documents
        //    //Environment.NewLine: dùng để xuống dòng trong khi ghi
        //    string[] lines = { "First line", "Second line", "Third line", Environment.NewLine};

        //    string docPath =
        //      Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    Console.WriteLine("uyen");
        //    //viết từng dòng vào file, mỗi dòng là một phần tử của string array đã cho.
        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        //    {
        //        foreach (string line in lines)
        //        {
        //            outputFile.WriteLine(line);
        //            outputFile.WriteLine(Environment.NewLine);
        //        }


        //    }
        //    Console.WriteLine("uyen");

        //    //viết tiếp các dòng tiếp theo trong file dùng append TRUE.
        //    using (StreamWriter outputFile1 = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
        //    {
        //        outputFile1.WriteLine("Fourth Line");
        //    }
        //    Console.WriteLine("uyen");
        //    ////Ghi đè lên file cũ.
        //    //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        //    //{
        //    //    foreach (string line in lines)
        //    //        outputFile.WriteLine(line);
        //    //}
        //}

        #endregion

        #region level 3: 



        #endregion

        #region
        #endregion

    }

}
