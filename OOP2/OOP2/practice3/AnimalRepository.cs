using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace practice3_1
{
    public class AnimalRepository
    {
        List<IAnimal> animalList = new List<IAnimal>();


        internal List<IAnimal> AnimalList { get => animalList; set => animalList = value; }

        public void ShowInfo()
        {
            foreach (var item in AnimalList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void ShowTerrestrialAnimal()
        {
            foreach (var item in AnimalList)
            {
                if (item is ITerrestrialAnimal)
                {
                    Console.WriteLine(item.ToString());
                    item.Move();
                }
            }
        }
        public void ShowMarineAnimal()
        {
            foreach (var item in AnimalList)
            {
                if (item is IMarineAnimal)
                {
                    Console.WriteLine(item.ToString());
                    item.Move();
                }
            }
        }

        public void ExportFile()
        {
            foreach (var item in AnimalList)
            {
                string path = item.ID + ".txt";
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine(item.ToString());
                }
            }
        }

        public void EditFile()
        {
            Console.Write("Enter ID file you want to edit: ");
            string str = Console.ReadLine();
            int id;
            while (!int.TryParse(str, out id))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            for (int i = 0; i < AnimalList.Count; i++)
            {
                if (AnimalList[i].ID == id)
                {
                    ChooseEdit(i);
                }
            }
        }
        public void ChooseEdit(int i)
        {
            Console.WriteLine("What do you want to change? Choose name (press 1) or age (press 2).");
            string str = Console.ReadLine();
            int chooseChange;
            while (!int.TryParse(str, out chooseChange) || chooseChange < 1 || chooseChange > 2)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            switch (chooseChange)
            {
                case 1:
                    Console.Write("Enter the name you want to change: ");
                    string name = Console.ReadLine();
                    AnimalList[i].Name = name;
                    break;
                case 2:
                    Console.Write("Enter the age you want to change: ");
                    str = Console.ReadLine();
                    int age;
                    while (!int.TryParse(str, out age))
                    {
                        Console.Write("Enter again! ");
                        str = Console.ReadLine();
                    }
                    AnimalList[i].Age = age;
                    break;
            }
        }
    }
}
