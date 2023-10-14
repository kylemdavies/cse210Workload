class FileHandler
{
    public void SaveFile()
    {
        Console.Write("What would you like the name of the file to be? (Ex. filename): ");
        string filename = Console.ReadLine();
        
    }
    public List<Book> ReadFile()
    {
        Console.Write("What would you like the name of the file to be? (Ex. filename): ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
        List<Book> books = new List<Book>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            Book b = new Book();
            b.CreateFromList(parts);
            books.Add(b);
        }
        return books;
    }
}