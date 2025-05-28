using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(List<Attack> attacks, string name, int level) : base(attacks, name, level, Type.Fire)
        {
        }

        public override string Attack()
        {
            Console.WriteLine("Write out attacks");
            int choice = 0;
            return Attacks[choice].Use(Level);
        }
    }
}
