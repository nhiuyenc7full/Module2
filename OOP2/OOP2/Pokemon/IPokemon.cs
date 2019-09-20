using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    interface IPokemon
    {
        int ID { get; set; }
        string Name { get; set; }
        string[] Type { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        int Speed { get; set; }

        string ShowInfo();
        void Sound();
        string RatingPokemon();
    }
}
