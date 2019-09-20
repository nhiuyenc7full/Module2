using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Pokemon
{
    public class PokemonRepository
    {
        private static List<string> filePokemon = new List<string>();
        public static string[] typePokemon;
        private static List<PokemonClass> pokemonList = new List<PokemonClass>();
        public static string[] listType = { "Normal", "Water", "Grass", "Fire", "Electric", "Ghost", "Dragon", "Rock", "Ice", "Bug", "Posion" };

        internal static List<PokemonClass> PokemonList { get => pokemonList; set => pokemonList = value; }
        public static List<string> FilePokemon { get => filePokemon; set => filePokemon = value; }

        public static string[] ChooseType(int numberType)
        {
            for (int i = 0; i < listType.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {listType[i]}");
            }
            typePokemon = new string[numberType];
            for (int i = 0; i < numberType; i++)
            {
                Console.Write($"Choose the Type {i + 1} of Pokemon: ");
                int type;
                string str = Console.ReadLine();
                while (!int.TryParse(str, out type) || type < 1 || type > 11)
                {
                    Console.Write("Enter again! ");
                    str = Console.ReadLine();
                }
                for (int j = 0; j < typePokemon.Length; j++)
                {
                    if (typePokemon[i] == listType[type - 1])
                    {
                        Console.WriteLine("Added.");
                    }
                    break;
                }
                typePokemon[typePokemon.Length - 1] = listType[type - 1];

                Console.WriteLine($"Type \"{listType[type - 1]}\" is added.");
            }
            return typePokemon;
        }

        public static void ShowListPokemon()
        {
            foreach (var item in pokemonList)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }

        public static void SearchPokemon()
        {
            Console.Write("What do you want to search? name (press 1) or id (press 2): ");
            string str = Console.ReadLine();
            int searchNumber;
            while (!int.TryParse(str, out searchNumber) || searchNumber < 1 || searchNumber > 2)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            if (searchNumber == 1)
            {
                Console.Write("Enter the name of Pokemon you want to search: ");
                str = Console.ReadLine();
                foreach (var item in pokemonList)
                {
                    if (item.Name.Equals(str))
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                }
                Console.WriteLine("Name is not found.");
            }
            else
            {
                Console.Write("Enter ID of Pokemon you want to search: ");
                str = Console.ReadLine();
                foreach (var item in pokemonList)
                {
                    if (item.ID.ToString().Equals(str))
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                }
                Console.WriteLine("ID is not found.");
            }

        }

        public static string ViewType(string[] list)
        {
            string data = String.Empty;
            for (int i = 0; i < list.Length; i++)
            {
                data += list[i] + " ";
            }
            return data;
        }

        public static void EditInfo()
        {
            Console.Write("Enter ID of Pokemon you want to edit: ");
            string str = Console.ReadLine();
            int idSearch;
            while(!int.TryParse(str, out idSearch) || idSearch > CheckFile() + 1001 || idSearch < 1001)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }

            int idMax = CheckFile() + 1001;
            for (int i = 1001; i < idMax; i++)
            {
                if (idSearch == i)
                {
                    FilePokemon.Clear();
                    DirectoryInfo di = new DirectoryInfo("D:/pokemon/");
                    FileInfo[] files = di.GetFiles("*.txt");
                    if (files.Length == 0)
                    {
                        Console.WriteLine("Folder is empty.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(File.ReadAllText("D:/pokemon/" + idSearch + ".txt")); 
                        Console.WriteLine("What do you want to change?\n" +
                            "Name: press 1\n" +
                            "Type: press 2\n" +
                            "Height: press 3\n" +
                            "Weight: press 4\n" +
                            "HP: press 5\n" +
                            "Attack: press 6\n" +
                            "Defence: press 7\n" +
                            "Speed: press 8\n");
                        str = Console.ReadLine();
                        int changeNumber = CheckChange(str);
                        ChangeInfo(changeNumber, "D:/pokemon/" + idSearch + ".txt", idSearch);
                        Console.WriteLine("Information was changed.");
                    
                    }
                }
            }
        }

        private static void ChangeInfo(int changeNumber, string path, int idSearch)
        {
            PokemonClass pokemonChange = new PokemonClass();
            string[] lines = File.ReadAllLines(path);
            using(StreamReader sr = new StreamReader(path)) { 
                
                pokemonChange.ID = idSearch;
                int indexOfValue = lines[0].IndexOf(": ") + 2;
                pokemonChange.Name = lines[0].Substring(indexOfValue).Trim();
                indexOfValue = lines[1].IndexOf(": ") + 2;
                string[] type = lines[1].Substring(indexOfValue).Trim().Split(" ");
                pokemonChange.Type = type;
                indexOfValue = lines[2].IndexOf(": ") + 2;
                pokemonChange.Height = int.Parse(lines[2].Substring(indexOfValue).Trim());
                indexOfValue = lines[3].IndexOf(": ") + 2;
                pokemonChange.Weight = int.Parse(lines[3].Substring(indexOfValue).Trim());
                indexOfValue = lines[4].IndexOf(": ") + 2;
                pokemonChange.HP = int.Parse(lines[4].Substring(indexOfValue).Trim());
                indexOfValue = lines[5].IndexOf(": ") + 2;
                pokemonChange.Attack = int.Parse(lines[5].Substring(indexOfValue).Trim());
                indexOfValue = lines[6].IndexOf(": ") + 2;
                pokemonChange.Defence = int.Parse(lines[6].Substring(indexOfValue).Trim());
                indexOfValue = lines[7].IndexOf(": ") + 2;
                pokemonChange.Speed = int.Parse(lines[7].Substring(indexOfValue).Trim());
                switch (changeNumber)
                {
                    case 1:
                        Console.Write("Enter new Name for Pokemon: ");
                        string str = Console.ReadLine();
                        pokemonChange.Name = str;
                        break;
                    case 2:
                        Console.WriteLine("Choose the new Type of pokemon: ");
                        Console.Write("How many types does the pokemon have? ");
                        str = Console.ReadLine();
                        int numberType;
                        while (!int.TryParse(str, out numberType) || numberType < 1 || numberType > 11)
                        {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                        }
                        string[] typeChange = ChooseType(numberType);
                        pokemonChange.Type = typeChange;

                        break;
                    case 3:
                        Console.WriteLine("Enter new Height for Pokemon: ");
                        str = Console.ReadLine();
                        int height;
                        while (!int.TryParse(str, out height) || height < 1 || height > 100)
                        {
                            Console.WriteLine("Enter again! ");
                            str = Console.ReadLine();
                        }
                        pokemonChange.Height = height;
                        break;
                    case 4:
                        Console.WriteLine("Enter new Weight for Pokemon: ");
                        str = Console.ReadLine();
                        int weight;
                        while (!int.TryParse(str, out weight) || weight < 1 || weight > 100)
                        {
                            Console.WriteLine("Enter again! ");
                            str = Console.ReadLine();
                        }
                        pokemonChange.Weight = weight;
                        break;
                    case 5:
                        Console.WriteLine("Enter new HP for Pokemon: ");
                        str = Console.ReadLine();
                        int hp = CheckHP(str);
                        pokemonChange.HP = hp;
                        break;
                    case 6:
                        Console.WriteLine("Enter new Attack for Pokemon: ");
                        str = Console.ReadLine();
                        pokemonChange.Attack = CheckADS(str);
                        break;
                    case 7:
                        Console.WriteLine("Enter new Defence for Pokemon: ");
                        str = Console.ReadLine();
                        pokemonChange.Defence = CheckADS(str);
                        break;
                    case 8:
                        Console.WriteLine("Enter new Speed for Pokemon: ");
                        str = Console.ReadLine();
                        pokemonChange.Speed = CheckADS(str);
                        break;

                }
            }
            File.Delete(path);
            foreach (var item in PokemonList)
            {
                if (item.ID == idSearch)
                {
                    PokemonList.Remove(item);
                    PokemonList.Add(pokemonChange);
                    break;
                }
            }

            ExportFile();

        }

        public static void ShowRating()
        {
            foreach (var item in pokemonList)
            {
                Console.Write(item.Name + ": ");
                Console.WriteLine(item.RatingPokemon()); 
            }
        }

        public static void ExportFile()
        {
            foreach (var item in pokemonList)
            {
                using (StreamWriter sw = new StreamWriter("D:/pokemon/" + item.ID + ".txt"))
                {
                    sw.WriteLine(item.ShowInfo());
                }
            }
            Console.WriteLine("File was exported.");
            //string strResultJson = JsonConvert.SerializeObject(PokemonList);
            //File.WriteAllText("pokemon.json", strResultJson);
        }

        public static void AddToListFile()
        {
            FilePokemon.Clear();
            DirectoryInfo di = new DirectoryInfo("D:/pokemon/");
            FileInfo[] files = di.GetFiles("*.txt");
            string path;
            if (files.Length == 0)
            {
                Console.WriteLine("Folder is empty.");
                return;
            }
            else
            {
                for (int i = 0; i < files.Length; i++)
                {
                    path = files[i].FullName.ToString();
                    //Console.WriteLine(File.ReadAllText(path));
                    filePokemon.Add(File.ReadAllText(path));
                }
            }
            Console.WriteLine("Added to file.");
            //string strJson = File.ReadAllText("pokemon.json");
            //PokemonList = JsonConvert.DeserializeObject<List<PokemonClass>>(strJson);
        }  

        public static int CheckHP(string str)
        {
            int hp;
            while (!int.TryParse(str, out hp) || hp < 1 || hp > 5000)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return hp;
        }

        public static int CheckADS(string str)
        {
            int num;
            while (!int.TryParse(str, out num) || num < 1 || num > 100)
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            return num;
        }

        public static int CheckChange(string str)
        {
            int number;
            while (!int.TryParse(str, out number) || number < 1 || number > 8)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            return number;
        }

        public static int CheckFile()
        {
            DirectoryInfo di = new DirectoryInfo("D:/pokemon/");
            FileInfo[] files = di.GetFiles("*.txt");
            int length = files.Length;
            return length;
        }

        public static void RefreshListPokemon()
        {

            DirectoryInfo di = new DirectoryInfo("D:/pokemon/");
            FileInfo[] files = di.GetFiles("*.txt");
            Console.WriteLine(files.Length);
            for (int i = 0; i < files.Length; i++)
            {
                PokemonClass pokemon = new PokemonClass();
                string path = files[i].FullName;
                string[] lines = File.ReadAllLines(path);
                using (StreamReader sr = new StreamReader(path))
                {
                    pokemon.ID = 1001 + i;
                    int indexOfValue = lines[0].IndexOf(": ") + 2;
                    pokemon.Name = lines[0].Substring(indexOfValue).Trim();
                    indexOfValue = lines[1].IndexOf(": ") + 2;
                    string[] type = lines[1].Substring(indexOfValue).Trim().Split(" ");
                    pokemon.Type = type;
                    indexOfValue = lines[2].IndexOf(": ") + 2;
                    pokemon.Height = int.Parse(lines[2].Substring(indexOfValue).Trim());
                    indexOfValue = lines[3].IndexOf(": ") + 2;
                    pokemon.Weight = int.Parse(lines[3].Substring(indexOfValue).Trim());
                    indexOfValue = lines[4].IndexOf(": ") + 2;
                    pokemon.HP = int.Parse(lines[4].Substring(indexOfValue).Trim());
                    indexOfValue = lines[5].IndexOf(": ") + 2;
                    pokemon.Attack = int.Parse(lines[5].Substring(indexOfValue).Trim());
                    indexOfValue = lines[6].IndexOf(": ") + 2;
                    pokemon.Defence = int.Parse(lines[6].Substring(indexOfValue).Trim());
                    indexOfValue = lines[7].IndexOf(": ") + 2;
                    pokemon.Speed = int.Parse(lines[7].Substring(indexOfValue).Trim());
                }
                pokemonList.Add(pokemon);
            }
        }
    }
}
