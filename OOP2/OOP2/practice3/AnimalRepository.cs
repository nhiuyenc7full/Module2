using System;
using System.Collections.Generic;
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

    }
}
