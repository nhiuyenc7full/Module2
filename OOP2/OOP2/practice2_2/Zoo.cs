using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_2
{
    class Zoo
    {
        //AnimalRepository cageList = new AnimalRepository();
        private static List<Cage> cageList = new List<Cage>();

      

        public void AddCage(Cage c)
        {
            cageList.Add(c);
            Console.WriteLine("List cage: ");
            foreach (var item in cageList)
            {
                Console.WriteLine("Cage's number: {0}.", item.CageNumber);
                Console.WriteLine(cageList.Count);
            }
        }
        public void RemoveCage(int c)
        {

            for (int i = 0; i < cageList.Count; i++)
            {
                if (cageList[i].CageNumber == c)
                {
                    cageList.RemoveAt(i);
                    i--;
                }
            }
        

            //foreach (var item in cageList)
            //{
            //    if (item.CageNumber == c)
            //    {
            //        cageList.Remove(item);
            //        break;
            //    }
            //}
            Console.WriteLine("List cage: ");
            
            foreach (var item in cageList)
            {
                Console.WriteLine("Cage's number: {0}.", item.CageNumber);
            }

        }
    }
}
