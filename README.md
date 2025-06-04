❓ Reflection Questions
Answer the following questions based on the code you’ve written and tested:

F: When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
It does not work. The fields are private and can only be reached through the matching property.

F: If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
In the Electric Pokemon Class.

F: If instead the new property should apply to all Pokémon, where would be the correct place to define it?
The abstract pokemon class.

F: What happens if you try to add a Charmander to a list that only allows WaterPokemon?
It would not work, since Charamander is a firepokemon. However if the list allowed pokemon generally it would be able to be added.

F: You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
Pokemon.

F: When you loop through the list and call Attack(), what ensures that the correct attack behavior is executed for each Pokémon?
The pokemon itself holds the list of possible attacks which is used during Attack() method

F: If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a List<Pokemon>? How could you still access it?
Because then it treats Pikachu as it is a Pokemon. You have to cast it back to pikachu before using its method.
                if (pokemon is Pikachu pikachu)
                {
                    pikachu.<method>();
                }
