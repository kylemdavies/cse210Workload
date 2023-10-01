public class Player
{
    private string _name;
    private int _jNum;

    public Player(string name, int jNum)
    {
        _name = name;
        _jNum = jNum;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} | {_jNum}");
    }
}