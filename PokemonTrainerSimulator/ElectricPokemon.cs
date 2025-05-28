using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(List<Attack> attacks, string name, int level) : base(attacks, name, level, Type.Electric)
        {
        }

        public override string Attack()
        {
            return PerformAttack();
        }
    }
}
