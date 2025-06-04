using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class Attack(string name, ElementType type, int basePower)
    {
        public string Name { get; } = name;
        public ElementType Type { get; } = type;
        public int BasePower { get; } = basePower;

        public void Use(int level)
        {
            Console.WriteLine($"{Name} hits with total power {BasePower + level}!");
        }
        public override string ToString()
        {
            return $"Name: {Name} Type: {Type} Base Power: {BasePower} ";
        }
    }
}
