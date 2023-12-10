public class Cycling : Activity
{
    public Cycling(string date, int time, float distance) : base(date,time,distance)
    {
        SetType("Cycling");
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