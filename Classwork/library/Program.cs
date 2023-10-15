
string attentionline = "-----------------------------";
Bookcase mybookcase = new Bookcase();
Book Harry_Potter = new Book("Harry Potter and the Philosopher's Stone","JK Rowling");
mybookcase.AddBook(Harry_Potter);
Harry_Potter.CheckOut();
Harry_Potter.CheckIn();

Book jane_eyre = new Book("Jane Eyre","Jane Austen");
jane_eyre.CheckOut();
jane_eyre.CheckIn();
mybookcase.AddBook(jane_eyre);

Book mistborn = new Book("Mistborn","Brandon Sanderson");
mybookcase.AddBook(mistborn);

mybookcase.FindBookByAuthor("Brandon");
Console.WriteLine(attentionline);
mybookcase.CountBooks();
Console.WriteLine(attentionline);
mybookcase.ShowPopularBooks(3);
Console.WriteLine(attentionline);
mybookcase.DisplayBooks();