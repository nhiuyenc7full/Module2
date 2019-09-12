using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_2
{
    class Dog : Animal
    {
        public Dog() : base()
        {

        }
        public Dog(string name) : base(name)
        {
            Name = name;
        }
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public Dog(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public override void Speak()
        {
            Console.WriteLine($"I'm {Name}.  Wo wo");
        }
    }
}
