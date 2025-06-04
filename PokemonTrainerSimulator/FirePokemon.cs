using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class FirePokemon : Pokemon
    {
        protected FirePokemon(List<Attack> attacks, string name, int level) : base(attacks, name, level, ElementType.Fire)
        {
        }
    }
}
