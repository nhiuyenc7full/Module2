using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class _28
    {
        static void Main()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);

            Console.WriteLine(wordsList[wordsList.Count - 1]);
            Console.WriteLine(result);

            //foreach (string s in wordsList)
            //{
            //    Console.WriteLine("Reverse String: " + s + "ABCD");
            //}
        }

    
    }
}
