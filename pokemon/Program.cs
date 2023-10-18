FileHandler file = new FileHandler();
Pokedex user = new Pokedex();
user.SetPokedex(file.ReadFile());
user.FindPokemonByGen(1);