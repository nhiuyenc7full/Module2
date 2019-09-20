using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class PokemonClass : IPokemon
    {
        private int iD = 1001;
        private static int _idCount = 0;
        //private static int count = 0;

        public string Name { get; set; }
        public string[] Type { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public int ID { get => iD; set => iD = value; }
        //public static int Count { get => count; set => count = value; }

        public PokemonClass(string name, string[] type, int height, int weight, int hp, int attack, int defence, int speed)
        {
            Name = name;
            Type = type;
            Height = height;
            Weight = weight;
            HP = hp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
            ID = ID + PokemonRepository.CheckFile();
            _idCount++;
        }

        public PokemonClass()
        {
        }
        public string ShowInfo()
        {
            return $"Name: {Name}\n" + 
                $"Type: {PokemonRepository.ViewType(Type)}\n" +
                $"Height: {Height}\n" +
                $"Weight: {Weight}\n" +
                $"HP: {HP}\n" +
                $"Attack: {Attack}\n" +
                $"Defence: {Defence}\n" +
                $"Speed: {Speed}\n" +
                $"ID: {ID}";
        }

        public virtual void Sound()
        {
        }
        public string RatingPokemon()
        {
            float average = (Attack + Defence + Speed) / 3f;
            return (average >= 90) ? "Perfect" :
                (average >= 60) ? "Good" :
                (average >= 40) ? "Medium" : "Bad";
        }
    }
}
