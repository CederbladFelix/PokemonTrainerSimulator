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
        private string name;
        private int level;

        public string Name 
        { 
            get => name;
            set
            {
                if (value.Length > 15 || value.Length < 2)
                {
                    throw new ArgumentException("Name must be between 2 and 15 characters long.");
                }
                name = value;
            } 
        }
        public int Level 
        { 
            get => level;
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level must be higher than 1.");
                }
                level = value;
            }
        }
        public ElementType Type { get; }

        protected Pokemon(List<Attack> attacks, string name, int level, ElementType type)
        {
            Attacks = attacks;
            Name = name;
            Level = level;
            Type = type;
        }

        public void RandomAttack()
        {
            int randomAttack = new Random().Next(Attacks.Count);

            Attacks[randomAttack].Use(Level);
        }

        public void Attack()
        {
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i}: {Attacks[i]}");
            }

            Console.Write("Choose an attack: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice >= Attacks.Count)
            {
                Console.WriteLine($"{Name} failed to attack due to invalid input.");
            }

            Attacks[choice].Use(Level);
        }

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
