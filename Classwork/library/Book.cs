public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
        _timesRead = 0;
        _available = true;
    }
    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
    public void Display()
    {
        Console.WriteLine($"{_name} by: {_author} | Times read: {_timesRead}");
        if (!_available)
        {
            Console.WriteLine("Checked Out");
        }
    }
    public bool IsAvailable()
    {
        return _available;
    }
    public int TimesRead()
    {
        return _timesRead;
    }
    public void CheckOut()
    {
        _available = false;
    }
    public void CheckIn()
    {
        _available = true;
        _timesRead ++;
    }

}