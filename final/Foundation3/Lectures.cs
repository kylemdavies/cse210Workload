using System.Reflection;

public class Lectures : Events
{
    private string _Speaker;
    private int _Capacity;
    public Lectures(string title, string description, string date, string time, string address, string speaker, int cap) : base(title,description,date,time,address)
    {
        _Speaker = speaker;
        _Capacity = cap;
    }
    public void FullDisplay()
    {
        Console.WriteLine($"{_Title} : {_Description} On {_Date} @ {_Time} Located at: {_Address} | Speaker: {_Speaker} Capacity: {_Capacity}");
    }
    public void ShortDisplay()
    {
        Console.WriteLine($"Lecture | {_Title} @ {_Date}");
    }
}