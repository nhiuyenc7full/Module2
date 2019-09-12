using System;
using System.Collections.Generic;
using System.Text;

namespace practice3_1
{
    class Cat : ITerrestrialAnimal
    {
        private int _iD = 200;
        private string _name;
        private int _age;
        private static int idCat = 1;
      

        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public Cat()
        {
            
        }
        public Cat(string name, int age)
        {
            _age = age;
            _name = name;
            _iD = ID + idCat;
            idCat++;

        }

        public void Move()
        {
            Console.WriteLine("Run");
        }
        public override string ToString()
        {
            return $"ID: {ID}; Name: {Name}; Age: {Age}; Type: {GetType()}";
        }
    }
}
