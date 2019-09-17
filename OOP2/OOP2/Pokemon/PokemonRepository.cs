using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokemon
{

    public static class PokemonRepository
    {
        private static List<string> filePokemon = new List<string>();
        public static List<string> typePokemon;
        private static List<PokemonClass> pokemonList = new List<PokemonClass>();
        public static string[] listType = { "Normal", "Water", "Grass", "Fire", "Electric", "Ghost", "Dragon", "Rock", "Ice", "Bug", "Posion" };

        internal static List<PokemonClass> PokemonList { get => pokemonList; set => pokemonList = value; }
        public static List<string> FilePokemon { get => filePokemon; set => filePokemon = value; }

        public static List<string> ChooseType(int numberType)
        {
            for (int i = 0; i < listType.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {listType[i]}");
            }
            typePokemon = new List<string>();
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
                typePokemon.Add(listType[type - 1]);

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
        public static string ViewType(List<string> list)
        {
            string data = String.Empty;
            for (int i = 0; i < list.Count; i++)
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
            while(!int.TryParse(str, out idSearch) || idSearch < 1000)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            for (int i = 0; i < pokemonList.Count; i++)
            {
                if (pokemonList[i].ID == idSearch)
                {
                    Console.WriteLine( pokemonList[i].ShowInfo()); 
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
                    int changeNumber;
                    while (!int.TryParse(str, out changeNumber) || changeNumber < 1 || changeNumber > 8)
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    ChangeInfo(changeNumber, pokemonList[i]);
                    Console.WriteLine("Information was changed.");
                    break;
                }
                Console.WriteLine("ID is not found.");
            }
        }

        private static void ChangeInfo(int changeNumber, PokemonClass pokemonFound)
        {
            switch(changeNumber)
            {
                case 1:
                    Console.Write("Enter new Name for Pokemon: ");
                    string str = Console.ReadLine();
                    pokemonFound.Name = str;
                    break;
                case 2:
                    Console.WriteLine("Choose the new Type of pokemon: ");
                    Console.Write("How many type does the pokemon have? ");
                    str = Console.ReadLine();
                    int numberType;
                    while (!int.TryParse(str, out numberType) || numberType < 1 || numberType > 11)
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    List<string> type = ChooseType(numberType);
                    pokemonFound.Type = type;

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
                    pokemonFound.Height = height;
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
                    pokemonFound.Weight = weight;
                    break;
                case 5:
                    Console.WriteLine("Enter new HP for Pokemon: ");
                    str = Console.ReadLine();
                    int hp;
                    while (!int.TryParse(str, out hp) || hp < 1 || hp > 5000)
                    {
                        Console.WriteLine("Enter again! ");
                        str = Console.ReadLine();
                    }
                    pokemonFound.HP = hp;
                    break;
                case 6:
                    Console.WriteLine("Enter new Attack for Pokemon: ");
                    str = Console.ReadLine();
                    int attack;
                    while (!int.TryParse(str, out attack) || attack < 1 || attack > 100)
                    {
                        Console.WriteLine("Enter again! ");
                        str = Console.ReadLine();
                    }
                    pokemonFound.Attack = attack;
                    break;
                case 7:
                    Console.WriteLine("Enter new Defence for Pokemon: ");
                    str = Console.ReadLine();
                    int defence;
                    while (!int.TryParse(str, out defence) || defence < 1 || defence > 100)
                    {
                        Console.WriteLine("Enter again! ");
                        str = Console.ReadLine();
                    }
                    pokemonFound.Defence = defence;
                    break;
                case 8:
                    Console.WriteLine("Enter new Speed for Pokemon: ");
                    str = Console.ReadLine();
                    int speed;
                    while (!int.TryParse(str, out speed) || speed < 1 || speed > 100)
                    {
                        Console.WriteLine("Enter again! ");
                        str = Console.ReadLine();
                    }
                    pokemonFound.Speed = speed;
                    break;
            }
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
                using (StreamWriter sww = new StreamWriter("D:/pokemon/" + item.ID + ".txt"))
                {
                    sww.WriteLine(item.ShowInfo());
                }
            }
            Console.WriteLine("File was exported.");
        }
        public static void ExportList()
        {
            FilePokemon.Clear();
            DirectoryInfo di = new DirectoryInfo("D:/pokemon/");
            FileInfo[] files = di.GetFiles("*.txt");
            string path;
            if(files.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }
            else
            {
                for (int i = 0; i < files.Length; i++)
                {
                    path = files[i].FullName.ToString();

                    string data = String.Empty;
                    data = File.ReadAllText(path);
                    filePokemon.Add(data);
                    Console.WriteLine($"Added {files[i].Name} into the list...");
                }
                Console.WriteLine("\nFile list Pokemon after export: ");
                for (int i = 0; i < FilePokemon.Count; i++)
                {
                    Console.WriteLine("{0} : {1}.", i + 1, files[i].Name);
                }
            }


        }  
    }
}
