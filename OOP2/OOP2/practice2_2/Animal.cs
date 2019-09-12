using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_2
{
    class Animal
    {
        private string _name;
        private int _age;
        private string _description;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Description { get => _description; set => _description = value; }

        public Animal() { }
        public Animal(string name)
        {
            _name = name;
        }
        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public Animal(string name, int age, string description)
        {
            _name = name;
            _age = age;
            _description = description;
        }

        public void ViewInfor()
        {
            //Console.WriteLine("Name: {0}; age: {1}; description: {2}.", Name, Age, Description);
            Console.WriteLine("Name: {0}.", Name);
        }
        public virtual void Speak()
        {

        }
    }
}
