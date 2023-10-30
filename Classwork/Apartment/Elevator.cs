public class Elevator
{
    protected int currentFloor = 0;
    protected bool doorOpen = false;
    public virtual void SetFloors(int minFloor, int maxFloor)
    {
        var floorList = Enumerable.Range(minFloor,maxFloor).ToList();
        currentFloor = minFloor;
    }
}