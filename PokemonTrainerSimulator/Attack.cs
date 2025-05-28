using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class Attack
    {
        public string Name;
        public Type Type;
        public int BasePower;

        public Attack(string name, Type type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public string Use(int level)
        {
            return $"{Name} hits with total power {BasePower + level}!";
        }
        public override string ToString()
        {
            return $"Name: {Name} Type: {Type} Base Power: {BasePower} ";
        }
    }
}
