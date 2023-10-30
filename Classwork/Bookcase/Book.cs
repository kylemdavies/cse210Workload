public class Book : Loanable
{
    private string _title;
    private string _ison;
    private int _upc;
    public Book(string title, string ison, int upc)
    {
        _title = title;
        _ison = ison;
        _upc = upc;
    }
    public override void Display()
    {
        ShowBookDetails();
    }
    public void ShowBookDetails()
    {
        Console.WriteLine($"{_title} : {_ison} : {_upc} : {_isCheckedIn}");
    }
}