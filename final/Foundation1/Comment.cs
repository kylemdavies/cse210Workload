using System.ComponentModel;

public class Comment
{
    private string _Commenter;
    private string _text;
    public Comment(string Commenter, string text)
    {
        _Commenter = Commenter;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($"{_Commenter}: {_text}");
    }
}