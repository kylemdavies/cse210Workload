using System.Dynamic;

class Pokedex
{
    private List<Pokemon> _pokemon = new List<Pokemon>();
    
    public void AddPokemon(Pokemon p)
    {
        _pokemon.Add(p);
    }
    public void DisplayPokedex()
    {
        foreach(Pokemon p in _pokemon)
        {
            p.Display();
        }
    }
    public List<Pokemon> GetPokedex()
    {
        return _pokemon;
    }
    public void SetPokedex(List<Pokemon> p)
    {
        _pokemon = p;
    }

    public void FindPokemonByGen(int gen)
    {
        Console.WriteLine($"\nPokemon in Gen: {gen}\n");
        foreach (Pokemon pokemon in _pokemon)
        {
            if(pokemon.IsGen(gen))
            {
                pokemon.Display();
            }
        }
    }

}