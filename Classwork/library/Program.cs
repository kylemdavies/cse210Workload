FileHandler file = new FileHandler();
string attentionline = "-----------------------------";
Bookcase mybookcase = new Bookcase();
mybookcase.SetBooks(file.ReadFile());

mybookcase.FindBookByAuthor("Brandon");
Console.WriteLine(attentionline);
mybookcase.CountBooks();
Console.WriteLine(attentionline);
mybookcase.ShowPopularBooks(3);
Console.WriteLine(attentionline);
mybookcase.DisplayBooks();
