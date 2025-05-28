using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class Squirtle : WaterPokemon, IEvolveable
    {
        public Squirtle(List<Attack> attacks, string name, int level) : base(attacks, name, level)
        {
        }

        public void Evolve()
        {
            PerformEvolution("Wartortle");
        }
    }
}
