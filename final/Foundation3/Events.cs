public class Events
{
// Event Title, Description, Date, Time, and Address
    protected string _Title;
    protected string _Description;
    protected string _Date;
    protected string _Time;
    protected string _Address;
    public Events(string title, string description, string date, string time, string address)
    {
        _Title = title;
        _Description = description;
        _Date = date;
        _Time = time;
        _Address = address;
    }
    public void StandardDisplay()
    {
        Console.WriteLine($"{_Title} : {_Description} On {_Date} @ {_Time} Located at: {_Address}");
    }
}