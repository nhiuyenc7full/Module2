﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExerciseArray
{
    public class program2
    {
        static void Main()
        {
            DisplayMenu();            
        }
        static void DisplayCountry(int choose)
        {
            int count = 1;
            string csvPath = "D:/FileExport/ReadCSV/country.csv";
            string[] lines = File.ReadAllLines(csvPath);
            CSVReader reader = new CSVReader(csvPath);

            Console.Write("How many countries you want to read? ");
            int nCountry = int.Parse(Console.ReadLine());
            Console.Write("How many countries per page? ");
            int countryInPage = int.Parse(Console.ReadLine());

            Country[] countriesA = reader.ReadAddToArray(nCountry);
            List<Country> countriesL = reader.ReadAddToList(nCountry);
            Dictionary<Country, int> countriesD = reader.ReadAddToDictionary(nCountry);
            Dictionary<string, List<Country>> countryContinent = reader.ReadAddToDictionary2(nCountry);

            switch (choose)
            {
                case 1:
                    foreach (var item in countriesA)
                    {
                        Console.WriteLine($"{item.Name.PadLeft(25)} : {item.Population}");
                        if (count++ % countryInPage == 0)
                        {
                            Console.WriteLine();
                            string str = Console.ReadLine();
                            if (str != "")
                            {
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (var item in countriesL)
                    {
                        Console.WriteLine($"{item.Name.PadLeft(25)} : {item.Population}");
                        if (count++ % countryInPage == 0)
                        {
                            Console.WriteLine();
                            string str = Console.ReadLine();
                            if (str != "")
                            {
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Type what you want to insert: ");
                    Console.Write("Country: ");
                    string country = Console.ReadLine();
                    Console.Write("Region: ");
                    string code = Console.ReadLine();
                    Console.Write("Country: ");
                    string region = Console.ReadLine();
                    Console.Write("Population: ");
                    int population = Convert.ToInt32(Console.ReadLine());
                    Country codegym = new Country(country, code , region, population);
                    for (int i = 0; i < countriesL.Count; i++)
                    {
                        if (countriesL[i].Name.Equals("Vietnam"))
                        {
                            countriesL.Insert(i, codegym);
                        }
                    }
                    Console.ReadLine();
                    foreach (var item in countriesL)
                    {
                        Console.WriteLine($"{item.Name.PadLeft(25)} : {item.Population}");
                    }
                    break;
                case 3:
                    foreach (var item in countriesD)
                    {
                        Console.WriteLine($"{item.Key.Name.PadLeft(25)} : {item.Value}");
                        if (count++ % countryInPage == 0)
                        {
                            Console.WriteLine();
                            string str = Console.ReadLine();
                            if (str != "")
                            {
                                break;
                            }
                        }
                    }

                    Console.WriteLine("Type what you want to insert: ");
                    Console.Write("Country: ");
                    country = Console.ReadLine();
                    Console.Write("Region: ");
                    code = Console.ReadLine();
                    Console.Write("Country: ");
                    region = Console.ReadLine();
                    Console.Write("Population: ");
                    population = Convert.ToInt32(Console.ReadLine());
                    Country newCountry = new Country(country, code, region, population);
                    break;
                case 4:
                    Console.WriteLine("Want to display country of continent ?");
                    string inputKey = Console.ReadLine();
                    if(countryContinent.ContainsKey(inputKey.ToLower()))
                    {
                        foreach (var item in countryContinent[inputKey])
                        {
                            Console.WriteLine($"{item.Population} : {item.Name}");
                        }
                        Console.WriteLine("--------------------");
                    }
                    else
                    {
                        Console.WriteLine("Not found this continent...");
                    }
                    break;
            }




        }
        public static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*          CSV READ SYSTEM          *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Read add to Array          *");
            Console.WriteLine("\t\t\t*     2. Read add to List           *");
            Console.WriteLine("\t\t\t*     3. Read add to Dictionary     *");
            Console.WriteLine("\t\t\t*     4. Read add to Dictionary2    *");
            Console.WriteLine("\t\t\t*     5. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, 4 or 5");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 6)
            {
                Console.Write("Enter again! Choose from 1 to 5! \t");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }

        public static void ChooseMenu(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    DisplayCountry(choose);
                    break;
                case 2:
                    DisplayCountry(choose);
                    break;
                case 3:
                    DisplayCountry(choose);
                    break;
                case 4:
                    DisplayCountry(choose);
                    break;
                case 5:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }
    }

    public class Country
    {
        private string name;
        private string code;
        private string region;
        private int population ;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Region { get => region; set => region = value; }
        public int Population { get => population; set => population = value; }

        public Country (string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }

    }

    public class CSVReader
    {
        private string csvFilePath;

        public CSVReader(string _csvFilePath)
        {
            csvFilePath = _csvFilePath;
        }
        public Country[] ReadAddToArray(int nCountry)
        {
            Country[] countries = new Country[nCountry];
            using(StreamReader sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();
                string str = String.Empty;

                    for (int i = 0; i < countries.Length; i++)
                    {
                        str = sr.ReadLine();
                        countries[i] = ConvertElement(str);
                    }

            }
            return countries;
        }

        public string RemoveChar(string str)
        {
            string[] nameUnformat = { ".", "\"", "\'" };
            for (int i = 0; i < nameUnformat.Length; i++)
            {
                str = str.Replace(nameUnformat[i], String.Empty);
            }
            return str;
        }

        public Country ConvertElement(string str)
        {
            string name;
            int population;
            string[] word = RemoveChar(str).Split(",");
            int count = 0;
            if (word.Length > 4)
            {
                name = word[count++] + word[count++];
            }
            else
            {
                name = word[count++];
            }
            string country = word[count++];
            string region = word[count++];
            try
            {   
                population = int.Parse(word[count++]);
            }
            catch
            {
                population = 0;
            }
            return new Country(name, country, region, population);
        }

        public List<Country> ReadAddToList(int nCountry)
        {
            List<Country> countries = new List<Country>();
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();
                string str = String.Empty;
                for (int i = 0; i < nCountry; i++)
                {
                    str = sr.ReadLine();
                    countries.Add(ConvertElement(str));
                }
            }
            return countries;
        }

        public Dictionary<Country, int> ReadAddToDictionary(int nCountry)
        {
            Dictionary<Country, int> countries = new Dictionary<Country, int>();
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();
                string str = String.Empty;
                for (int i = 0; i < nCountry; i++)
                {
                    str = sr.ReadLine();
                    countries.Add(ConvertElement(str), ConvertElement(str).Population);
                }
            }
            return countries;
        }

        public Dictionary<string, List<Country>> ReadAddToDictionary2(int nCountry)
        {
            Dictionary<string, List<Country>> countryContinent = new Dictionary<string, List<Country>>();
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                sr.ReadLine();
                string str = String.Empty;
                for (int i = 0; i < nCountry; i++)
                {
                    str = sr.ReadLine();
                    Country country = ConvertElement(str);
                    string region = country.Region;
                    if (countryContinent.ContainsKey(region))
                    {
                        countryContinent[region].Add(country);
                    }
                    else
                    {
                        List<Country> newCountry = new List<Country>();
                        newCountry.Add(country);
                        countryContinent.Add(region, newCountry);
                    }
                }
            }
            return countryContinent;
        }
    }
}