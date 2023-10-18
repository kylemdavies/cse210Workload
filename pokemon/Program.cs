FileHandler file = new FileHandler();
Pokedex user = new Pokedex();
Pokemon bulbasaur = new Pokemon(1,1,"Bulbasaur","Grass","Poison",0.7,6.9);
Pokemon squirtle = new Pokemon(2,1,"Squirtle","Water","Poison",0.5,9);
Pokemon charmander = new Pokemon(3,1,"Charmander","Fire","None",0.6,8.5);
user.AddPokemon(bulbasaur);
user.AddPokemon(squirtle);
user.AddPokemon(charmander);
file.SaveFile(user.GetPokedex());