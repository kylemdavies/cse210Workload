public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int ComCount()
    {
        return _comments.Count();
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} | By: {_author} | {_length} Seconds");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}