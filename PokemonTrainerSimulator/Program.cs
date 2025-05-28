namespace PokemonTrainerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var flamethrower = new Attack("Flamethrower", Type.Fire, 12);
            var ember = new Attack("Ember", Type.Fire, 6);

            var waterGun = new Attack("Water Gun", Type.Water, 12);
            var waterPulse = new Attack("Water Pulse", Type.Water, 6);

            var nuzzle = new Attack("Nuzzle", Type.Electric, 12);
            var thunderShock = new Attack("Thunder Shock", Type.Electric, 6);

            var fireAttacks = new List<Attack>() { flamethrower, ember };
            var waterAttacks = new List<Attack>() { waterGun, waterPulse };
            var electicAttacks = new List<Attack>() { nuzzle, thunderShock };

            var pokemonList = new List<Pokemon>();

            var charamander = new Charmander(fireAttacks, "Charamander", 23);
            var squirtle = new Squirtle(waterAttacks, "Squirtle", 25);
            var pikachu = new Pikachu(electicAttacks, "Pikachu", 30);

            pokemonList.AddRange([charamander, squirtle, pikachu]);

            for (int i = 0; i < pokemonList.Count; i++)
            {
                pokemonList[i].RaiseLevel();
                pokemonList[i].Attack();

                if (pokemonList[i] is IEvolveable evolveable)
                {
                    evolveable.Evolve();
                }
            }
        }
    }
}
