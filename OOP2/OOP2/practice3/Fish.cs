using System;
using System.Collections.Generic;
using System.Text;

namespace practice3_1
{
    class Fish : IMarineAnimal
    {
        private int _iD = 300;
        private string _name;
        private int _age;
        private static int idFish = 1;
       

        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Fish(string name, int age)
        {
            _age = age;
            _name = name;
            _iD = ID + idFish;
            idFish++;

        }

        public void Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {
            return $"ID: {ID}; Name: {Name}; Age: {Age}; Type: {GetType()}";
        }
    }
}
