using System.Xml.Serialization;

class FileHandler
{
    string fileName = "filename";
    public void SaveFile(List<Book> books)
    {
        Console.Write("Please enter the filename (Ex. 'filename'): ");
        string fileName = Console.ReadLine() ?? string.Empty;
        using (StreamWriter outputFile = new StreamWriter(fileName + ".txt"))
        {
            foreach (var book in books)
            {
                outputFile.WriteLine(book.Stringify());
            }
        }
    }
    public List<Book> ReadFile()
    {
        Console.Write("What would you like the name of the file to be? (Ex. filename): ");
        string filename = Console.ReadLine() ?? string.Empty;
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