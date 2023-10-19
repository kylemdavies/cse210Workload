FileHandler file = new FileHandler();
Pokedex user = new Pokedex();
user.SetPokedex(file.ReadFile());
user.FindPokemonByGen(1);
user.FindPokemonByType(1,"Fire");