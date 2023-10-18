class Pokedex
{
    private List<Pokemon> _pokemon = new List<Pokemon>();
    
    public void AddPokemon(Pokemon p)
    {
        _pokemon.Add(p);
    }
    public void DisplayPokedex()
    {
        foreach(Pokemon pokemon in _pokemon)
        {
            pokemon.Display();
        }
    }

    // public void FindPokemonByGen(string gen)
    // {
    //     Console.WriteLine($"\nPokemon in Gen: {gen}\n");
    //     foreach (Pokemon pokemon in _pokemon)
    //     {
    //         if(pokemon.HasPokemon(gen))
    //         {
    //             pokemon.Display();
    //         }
    //     }
    // }

}