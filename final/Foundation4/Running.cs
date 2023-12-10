using System.Runtime.CompilerServices;

public class Running : Activity
{
    
    public Running(string date, int time, float distance) : base(date,time,distance)
    {
        SetType("Running");
    }
    public override float CalculateDistanceMPH()
    {
        return GetDistance();
    }
    public override float CalculateDistanceKPH()
    {
        return GetDistance() * 1.61f;
    }
}