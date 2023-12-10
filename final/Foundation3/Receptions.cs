public class Receptions:Events
{
    private string _RSVPEmail;
    public Receptions(string title, string description, string date, string time, string address, string RSVPEmail) : base(title,description,date,time,address)
    {
        _RSVPEmail = RSVPEmail;
    }
        public void FullDisplay()
    {
        Console.WriteLine($"{_Title} : {_Description} On {_Date} @ {_Time} Located at: {_Address} | Email to RSVP: {_RSVPEmail}");
    }
        public void ShortDisplay()
    {
        Console.WriteLine($"Reception | {_Title} @ {_Date}");
    }

}