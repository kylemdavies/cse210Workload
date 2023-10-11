class Bookcase
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book b)
    {
        _books.Add(b);
    }
    public void DisplayBooks()
    {
        foreach(Book book in _books)
        {
            book.Display();
        }
    }
}