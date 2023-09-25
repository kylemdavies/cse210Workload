public class laptop
{
    private double _screenSize;
    private string _os;
    private bool _touchScreen;

    public laptop(double screenSize, string os, bool ts)
    {
        _screenSize =  screenSize;
        _os = os;
        _touchScreen = ts;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"{_screenSize} {_os} {_touchScreen}");
    }
}