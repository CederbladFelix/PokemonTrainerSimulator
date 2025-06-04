namespace PokemonTrainerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonList = GetPokemonList();

            foreach (var pokemon in pokemonList)
            {
                pokemon.RaiseLevel();
                pokemon.Attack();

                if (pokemon is IEvolveable evolveable)
                {
                    evolveable.Evolve();
                }
            }

        }

        private static List<Pokemon> GetPokemonList()
        {
            Charmander charamander = CreateCharamander();
            Squirtle squirtle = CreateSquirtle();
            Pikachu pikachu = CreatePikachu();

            var pokemonList = new List<Pokemon>();

            pokemonList.AddRange([charamander, squirtle, pikachu]);
            return pokemonList;
        }

        private static Pikachu CreatePikachu()
        {
            var nuzzle = new Attack("Nuzzle", ElementType.Electric, 12);
            var thunderShock = new Attack("Thunder Shock", ElementType.Electric, 6);
            var electicAttacks = new List<Attack>() { nuzzle, thunderShock };
            var pikachu = new Pikachu(electicAttacks, "Pikachu", 30);
            return pikachu;
        }

        private static Squirtle CreateSquirtle()
        {
            var waterGun = new Attack("Water Gun", ElementType.Water, 12);
            var waterPulse = new Attack("Water Pulse", ElementType.Water, 6);
            var waterAttacks = new List<Attack>() { waterGun, waterPulse };
            var squirtle = new Squirtle(waterAttacks, "Squirtle", 25);
            return squirtle;
        }

        private static Charmander CreateCharamander()
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var fireAttacks = new List<Attack>() { flamethrower, ember };
            var charamander = new Charmander(fireAttacks, "Charamander", 23);
            return charamander;
        }
    }
}
