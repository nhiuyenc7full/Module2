using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t*************************************");
            Console.WriteLine("\t\t\t*     POKEMON MANAGEMENT SYSTEM     *");
            Console.WriteLine("\t\t\t*                                   *");
            Console.WriteLine("\t\t\t*     1. Insert new pokemon         *");
            Console.WriteLine("\t\t\t*     2. View list of pokemon       *");
            Console.WriteLine("\t\t\t*     3. Search pokemon             *");
            Console.WriteLine("\t\t\t*     4. Edit pokemon               *");
            Console.WriteLine("\t\t\t*     5. Show sound                 *");
            Console.WriteLine("\t\t\t*     6. Rating                     *");
            Console.WriteLine("\t\t\t*     7. Export file                *");
            Console.WriteLine("\t\t\t*     8. Add into list              *");
            Console.WriteLine("\t\t\t*     9. Exit                       *");
            Console.WriteLine("\t\t\t************************************* \n");

            Console.WriteLine("\t\tWhat do you want? Choose 1, 2, 3, 4, 5, 6, 7, 8 or 9");
            string str = Console.ReadLine();
            int choose;
            while (!int.TryParse(str, out choose) || choose < 0 || choose > 9)
            {
                Console.Write("Enter again! Choose from 1 to 9! ");
                str = Console.ReadLine();
            }
            ChooseMenu(choose);
        }

        static void ChooseMenu(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    CreatePokemon();
                    break;
                case 2:
                    PokemonRepository.ShowListPokemon();
                    break;
                case 3:
                    PokemonRepository.SearchPokemon();
                    break;
                case 4:
                    PokemonRepository.EditInfo();
                    break;
                case 5:
                    Console.WriteLine("Doing...");
                    break;
                case 6:
                    PokemonRepository.ShowRating();
                    break;
                case 7:
                    PokemonRepository.ExportFile();
                    break;
                case 8:
                    PokemonRepository.ExportList();
                    break;
                case 9:
                    Console.WriteLine("Exit the program.");
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DisplayMenu();
        }
        static void CreatePokemon()
        {
            Console.Write("Enter the Name of pokemon: ");
            string name = Console.ReadLine();

            Console.WriteLine("Choose the Type of pokemon: ");
            Console.Write("How many type does the pokemon have? ");
            string str = Console.ReadLine();
            int numberType;
            while (!int.TryParse(str, out numberType) || numberType < 1 || numberType > 11)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            List<string> type = PokemonRepository.ChooseType(numberType);

            Console.Write("Enter the Height of pokemon: ");
            int height;
            str = Console.ReadLine();
            while (!int.TryParse(str, out height))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }

            Console.Write("Enter the Weight of pokemon: ");
            int weight;
            str = Console.ReadLine();
            while (!int.TryParse(str, out weight))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter HP of pokemon: ");
            int hp;
            str = Console.ReadLine();
            while (!int.TryParse(str, out hp) || hp < 1 || hp > 5000)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter the Attack of pokemon: ");
            int attack;
            str = Console.ReadLine();
            while (!int.TryParse(str, out attack) || attack < 1 || attack > 100)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter Defence of pokemon: ");
            int defence;
            str = Console.ReadLine();
            while (!int.TryParse(str, out defence) || defence < 1 || defence > 100)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Console.Write("Enter Speed of pokemon: ");
            int speed;
            str = Console.ReadLine();
            while (!int.TryParse(str, out speed) || speed < 1 || speed > 100)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            PokemonClass pokemon = new PokemonClass(name, type, height, weight, hp, attack, defence, speed);
            PokemonRepository.PokemonList.Add(pokemon);
        }

    }
}
