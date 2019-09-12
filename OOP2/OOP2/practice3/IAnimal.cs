using System;
using System.Collections.Generic;
using System.Text;

namespace practice3_1
{
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        void Move();
    }
}
