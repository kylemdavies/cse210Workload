public class OGathering:Events
{
    private string _Weather;
    public OGathering(string title, string description, string date, string time, string address, string weather) : base(title,description,date,time,address)
    {
        _Weather = weather;
    }
        public void FullDisplay()
    {
Console.WriteLine($"{_Title} : {_Description} On {_Date} @ {_Time} Located at: {_Address} | The weather will be: {_Weather}");
    }
        public void ShortDisplay()
    {
        Console.WriteLine($"Outdoor Gathering | {_Title} @ {_Date}");
    }

}