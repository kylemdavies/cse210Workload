public abstract class Activity
{
    private string _date;
    private string _type = "";
    private int _time;
    private float _distance;
    private float _speed;
    private float _pace;
    public Activity(string date, int time, float distance)
    {
        _date = date;
        _time = time;
        _distance = distance;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public float GetDistance()
    {
        return _distance;
    }
    public void SetDistanceKPH()
    {
        _distance = CalculateDistanceKPH();;
    }
    public abstract float CalculateDistanceMPH();
    public abstract float CalculateDistanceKPH();
    public float CalculateSpeed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }
    public float CalculatePace()
    {
        _pace = _time / _distance;
        return _pace;
    }

    public void DisplaySummaryMPH()
    {
        Console.WriteLine($"{_date} {_type} ({_time})- Distance {CalculateDistanceMPH()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile.");
    }
    public void DisplaySummaryKPH()
    {
        SetDistanceKPH();
        Console.WriteLine($"{_date} {_type} ({_time})- Distance {_distance} kilometers, Speed {CalculateSpeed()} KPH, Pace: {CalculatePace()} min per kilometer.");
    }
}