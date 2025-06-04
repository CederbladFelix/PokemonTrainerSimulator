namespace PokemonTrainerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var waterGun = new Attack("Water Gun", ElementType.Water, 12);
            var waterPulse = new Attack("Water Pulse", ElementType.Water, 6);

            var nuzzle = new Attack("Nuzzle", ElementType.Electric, 12);
            var thunderShock = new Attack("Thunder Shock", ElementType.Electric, 6);

            var fireAttacks = new List<Attack>() { flamethrower, ember };
            var waterAttacks = new List<Attack>() { waterGun, waterPulse };
            var electicAttacks = new List<Attack>() { nuzzle, thunderShock };

            var pokemonList = new List<Pokemon>();

            var charamander = new Charmander(fireAttacks, "Charamander", 23);
            var squirtle = new Squirtle(waterAttacks, "Squirtle", 25);
            var pikachu = new Pikachu(electicAttacks, "Pikachu", 30);

            pokemonList.AddRange([charamander, squirtle, pikachu]);

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
    }
}
