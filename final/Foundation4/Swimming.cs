public class Swimming : Activity
{
    public Swimming(string date, int time, float distance) : base(date,time,distance)
    {
        SetType("Swimming");
    }

    public override float CalculateDistanceMPH()
    {
        return (GetDistance() * 50 / 1000) * 0.62f;
    }
    public override float CalculateDistanceKPH()
    {
        return GetDistance() * 50 / 1000;
    }
}