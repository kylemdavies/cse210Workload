class Program
{
    static void Main(string[] args)
    {
        Bookcase mybookcase = new Bookcase();
        Book Harry_Potter = new Book("Harry Potter and the Philosopher's Stone","JK Rowling");
        mybookcase.AddBook(Harry_Potter);
        Harry_Potter.CheckOut();
        Harry_Potter.CheckIn();
        mybookcase.DisplayBooks();
    }
}