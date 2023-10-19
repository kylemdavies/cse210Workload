class FileHandler
{
    string fileName = "filename";
    public void SaveFile(List<Pokemon> pokemons)
    {
        Console.Write("Please enter the filename (Ex. 'filename'): ");
        fileName = Console.ReadLine() ?? string.Empty;
        using (StreamWriter outputFile = new StreamWriter(fileName + ".txt"))
        {
            foreach (var pokemon in pokemons)
            {
                outputFile.WriteLine(pokemon.Stringify());
            }
        }
    }
    public List<Pokemon> ReadFile()
    {
        
        Console.Write("What would you like the name of the file to be? (Ex. filename): ");
        string filename = Console.ReadLine() ?? string.Empty;
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
        List<Pokemon> pokemons = new List<Pokemon>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            Pokemon p = new Pokemon();
            p.CreateFromList(parts);
            pokemons.Add(p);
        }
        return pokemons;
    }
    // public FileHandler()
    // {

    // }
    // public class ListFileHandler<T> where T : class
    // {
    // public static void SaveListToFile(string filePath, List<T> list)
    // {
    //     try
    //     {
    //         XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
    //         using (TextWriter writer = new StreamWriter(filePath))
    //         {
    //             serializer.Serialize(writer, list);
    //         }
    //         Console.WriteLine("List saved to " + filePath);
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Error while saving list to file: " + ex.Message);
    //     }
    // }

    // public static List<T> LoadListFromFile(string filePath)
    // {
    //     List<T> list = new List<T>();
    //     try
    //     {
    //         XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
    //         using (TextReader reader = new StreamReader(filePath))
    //         {
    //             list = (List<T>)serializer.Deserialize(reader);
    //         }
    //         Console.WriteLine("List loaded from " + filePath);
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Error while loading list from file: " + ex.Message);
    //     }

    //     return list;
    // }
    // }
}