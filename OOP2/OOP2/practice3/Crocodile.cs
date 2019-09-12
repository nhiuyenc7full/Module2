using System;
using System.Collections.Generic;
using System.Text;

namespace practice3_1
{
    class Crocodile : IMarineAnimal, ITerrestrialAnimal
    {
        private int _iD = 100;
        private string _name;
        private int _age;
        private static int idCro = 1;
        

        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
      
        public Crocodile(string name, int age)
        {
            _age = age;
            _name = name;
            _iD = ID + idCro;
            idCro++;
           
        } 
        public void Move()
        {
            Console.WriteLine("Swim & Run");
        }
        public override string ToString()
        {
            return $"ID: {ID}; Name: {Name}; Age: {Age}; Type: {GetType()}";
        }
    }
}
