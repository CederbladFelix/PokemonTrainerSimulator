using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal abstract class Pokemon
    {
        protected List<Attack> Attacks;
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 0;
        public Type Type { get; }

        protected Pokemon(List<Attack> attacks, string name, int level, Type type)
        {
            Attacks = attacks;
            Name = name;
            Level = level;
            Type = type;
        }


        public abstract string Attack();

        public void RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} leveled up to {Level}!");
        }

        protected void PerformEvolution(string newName)
        {
            string oldName = Name;
            Name = newName;
            Level += 10;
            Console.WriteLine($"{oldName} is evolving... Now it's {Name}! Level {Level}!");
        }

    }
}
