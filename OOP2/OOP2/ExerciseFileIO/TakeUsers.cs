using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
namespace ExerciseFileIO
{
    class TakeUser
    {
        static string str;
        static string info;
        static void Main(string[] args)
        {
            string path = "https://randomuser.me/api/";
            string file = "file.txt";
            start_get(path);
            using (StreamWriter sww = new StreamWriter(file))
            {
                sww.WriteLine(info);
            }
            using (StreamReader swr = new StreamReader(file))
            {
                string data = string.Empty;
                int startIndex = info.IndexOf("[");
                int endIndex = info.IndexOf("]");
                Console.WriteLine(startIndex);
                Console.WriteLine(endIndex);
                info = info.Substring(startIndex + 2, endIndex - 14);
                Console.WriteLine(info);
            }
            JsonSerializer json = new JsonSerializer();
            using (StreamWriter sww = new StreamWriter(file))
            {
                sww.WriteLine(info);
            }
            Loop();
        }


        static void Loop()
        {
            Console.WriteLine("What do you want to search?");
            str = Console.ReadLine();
            Console.WriteLine(GetElement(str));
            Loop();
        }
        static string GetElement(string str)
        {
            if(info.Contains(str))
            {
                int indexKey = info.IndexOf(str);
                if (info.Contains(str + "\":\""))
                {
                    //int indexNext = 
                    //string result = 
                }
            }
            else
            {
                return "Not found that key.";
            }

            return str;
        }
        private static void start_get(string path)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
                (string.Format(path));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            info = _Answer.ReadToEnd();
        }
    }
}