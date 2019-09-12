using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_2
{
    class Cage
    {
        private static int _cageNumber = 0;
        public List<Animal> animalList= new List<Animal>();

        public int CageNumber { get => _cageNumber; set => _cageNumber = value; }

        public Cage(int cageNumber)
        {
            _cageNumber = cageNumber;
        }

        public void AddAnimal(Animal a)
        {
            animalList.Add(a);

            foreach (var item in animalList)
            {
                item.ViewInfor();
            }
        }
        public void RemoveAnimal(string name)
        {
            foreach (var item in animalList)
            {
                if (item.Name == name)
                {
                    animalList.Remove(item);
                    break;
                }
            }
            foreach (var item in animalList)
            {
                item.ViewInfor();
            }
        }
        public void IterateAnimal()
        {
            foreach (var item in animalList)
            {
                Console.WriteLine(item.Name);
                item.Speak();
            }
        }
    }
}
