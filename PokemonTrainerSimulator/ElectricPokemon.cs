using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class ElectricPokemon : Pokemon
    {
        protected ElectricPokemon(List<Attack> attacks, string name, int level) : base(attacks, name, level, ElementType.Electric)
        {
        }

    }
}
