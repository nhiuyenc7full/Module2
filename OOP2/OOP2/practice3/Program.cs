using System;
using System.Collections.Generic;

namespace practice3_1
{
    class Program
    {
        //static List<IAnimal> animalList = new List<IAnimal>();
        static Crocodile crocodile;
        static Cat cat;
        static Fish fish;
        static AnimalRepository animalRepo = new AnimalRepository();
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("          ***********************************");
            Console.WriteLine("          *     ANIMAL MANAGEMENT SYSTEM    *");
            Console.WriteLine("          * 1. Create a Crocodile           *");
            Console.WriteLine("          * 2. Create a Cat                 *");
            Console.WriteLine("          * 3. Create a Fish                *");
            Console.WriteLine("          * 4. View Terrestrial Animals     *");
            Console.WriteLine("          * 5. View Marine Animals          *");
            Console.WriteLine("          * 6. View All Animals             *");
            Console.WriteLine("          * 7. Delete Animal                *");
            Console.WriteLine("          * 8. Export file                  *");
            Console.WriteLine("          * 9. Exit                         *");
            Console.WriteLine("          ***********************************");
            int choose;
            string str = Console.ReadLine();
            while (!int.TryParse(str, out choose) || choose <= 0 || choose > 9)
            {
                Console.Write("Enter again! ");
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
                    {
                        Console.Write("Enter name of crocodile: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter age of crocodile: ");
                        string age = Console.ReadLine();
                        int inputAge;
                        while (!int.TryParse(age, out inputAge) || inputAge <= 0)
                        {
                            Console.WriteLine("Enter again!");
                            age = Console.ReadLine();
                        }

                        crocodile = new Crocodile(name, inputAge);
                        animalRepo.AnimalList.Add(crocodile);
                        Console.Clear();
                        Console.WriteLine("Added a new crocodile.\n");
                    }
                    break;
                case 2:
                    {
                        Console.Write("Enter name of cat: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter age of cat: ");
                        string age = Console.ReadLine();
                        int inputAge;
                        while (!int.TryParse(age, out inputAge) || inputAge <= 0)
                        {
                            Console.WriteLine("Enter again!");
                            age = Console.ReadLine();
                        }

                        cat = new Cat(name, inputAge);
                        animalRepo.AnimalList.Add(cat);
                        Console.Clear();

                        Console.WriteLine("Added a new cat.\n");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter name of fish: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter age of fish: ");
                        string age = Console.ReadLine();
                        int inputAge;
                        while (!int.TryParse(age, out inputAge) || inputAge <= 0)
                        {
                            Console.WriteLine("Enter again!");
                            age = Console.ReadLine();
                        }

                        fish = new Fish(name, inputAge);
                        animalRepo.AnimalList.Add(fish);
                        Console.Clear();
                        Console.WriteLine("Added a new fish.\n");
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("View Terrestrial Animals: ");
                        animalRepo.ShowTerrestrialAnimal();
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("View Marine Animals: ");
                        animalRepo.ShowMarineAnimal();
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("View All Animals: ");
                        animalRepo.ShowInfo();
                    }
                    break;
                case 7:
                    {
                        Console.Write("Enter the ID of animal you want to delete: ");
                        string str = Console.ReadLine();
                        int iDInput;
                        while (!int.TryParse(str, out iDInput))
                        {
                            Console.WriteLine("Enter again! ");
                            str = Console.ReadLine();
                        }
                        for (int i = 0; i < animalRepo.AnimalList.Count; i++)
                        {
                            if (iDInput == animalRepo.AnimalList[i].ID)
                            {
                                animalRepo.AnimalList.RemoveAt(i);
                                break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Deleted an animal. ");
                    }
                    break;
                case 8:
                    animalRepo.ExportFile();
                    Console.WriteLine("All animal's information was exported in file.");
                    break;
                case 9:
                    {
                        Console.WriteLine("Exit");
                        Environment.Exit(Environment.ExitCode);
                    }
                    break;
            }
            DisplayMenu();
        }
    }
}
