using System;
using System.Collections.Generic;
using System.Text;

namespace practice2_2
{
    class Tiger : Animal
    {
        public Tiger() : base()
        {

        }
        public Tiger(string name) : base(name)
        {
            Name = name;
        }
        public Tiger(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public Tiger(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public override void Speak()
        {
            Console.WriteLine($"I'm {Name}. Gru gru");
        }
    }
}
