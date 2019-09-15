using System;

namespace practice2_2
{
    class Program
    {
        static Cage cage;
        static Zoo zoo;
        static int cageNumber;
        static string str;
        static int choose;
        static Dog dog;
        static Cat cat;
        static Tiger tiger;

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("ZOO MANAGEMENT SYSTEM:");
            Console.WriteLine("1. Add cage");
            Console.WriteLine("2. Remove cage");
            Console.WriteLine("3. Add animal");
            Console.WriteLine("4. Remove animal");
            Console.WriteLine("5. Iterate Animals");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n***********************************");

            
            str = Console.ReadLine();
            while (!int.TryParse(str, out choose))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Process(choose);
        }
        static void Process(int choose)
        {
            zoo = new Zoo();
            
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Add a new cage: ");
                        Console.WriteLine("Add the cage's number: ");
                        string str = Console.ReadLine();
                        while (!int.TryParse(str, out cageNumber) || cageNumber < 0 )
                        {
                            Console.WriteLine("Enter again! ");
                            str = Console.ReadLine();
                        }
                        cage = new Cage(cageNumber);  
                        zoo.AddCage(cage);

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter the cage's number you want to remove: ");
                        string str = Console.ReadLine();
                        
                        while(!int.TryParse(str, out cageNumber))
                        {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                        }
                        zoo.RemoveCage(cageNumber);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Choose 'dog'(press 1), 'cat' (press 2) or 'tiger' (press 3) to add: ");
                        str = Console.ReadLine();
                        int child;
                        while (!int.TryParse(str, out child)) 
                            {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                            }
                        switch (child)
                        {
                            case 1:
                                Console.Write("Enter the name of dog: ");
                                string name = Console.ReadLine();

                                dog = new Dog(name);
                                cage.AddAnimal(dog);
                                break;
                            case 2:
                                Console.Write("Enter the name of cat: ");
                                name = Console.ReadLine();

                                cat = new Cat(name);
                                cage.AddAnimal(cat);
                                break;
                            case 3:
                                Console.Write("Enter the name of tiger: ");
                                name = Console.ReadLine();

                                tiger = new Tiger(name);
                                cage.AddAnimal(tiger);
                                break;
                            default:
                                Console.Write("Enter again! ");
                                str = Console.ReadLine();
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Write("Enter the name of animal you want to remove: ");
                        string name = Console.ReadLine();
                        cage.RemoveAnimal(name);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("\nIterate animal in the cage:");
                        Console.Write("Animal");
                        cage.IterateAnimal();
                    }
                    break;
                case 6:
                    Console.WriteLine("Exit.");
                    Environment.Exit(Environment.ExitCode);
                    break;
                default:
                    Console.WriteLine("Enter 1, 2, 3, 4, 5 or 6: ");
                    Menu();
                    break;
            }
            Menu();
        }
        #region chooseAnimal
        //static Animal ChooseAnimal(string str)
        //{
        //    switch (str)
        //    {
        //        case "dog":
        //            Console.Write("Enter the name of dog: ");
        //            string name = Console.ReadLine();
                    
        //            return dog = new Dog(name);
        //        case "cat":
        //            Console.Write("Enter the name of cat: ");
        //            name = Console.ReadLine();
                    
        //            return cat = new Cat(name);
        //        case "tiger":
        //            Console.Write("Enter the name of tiger: ");
        //            name = Console.ReadLine();
                    
        //            return tiger = new Tiger(name);
        //        default:
        //            Console.Write("Enter again! ");
        //            str = Console.ReadLine();
        //            break;
        //    }
        //}
        #endregion
    }
}
