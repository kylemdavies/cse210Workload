public class VIP : Elevator
{
    public override void SetFloors(int minFloor, int maxFloor)
    {
        var floorList = Enumerable.Range(minFloor,maxFloor).ToList();
        currentFloor = minFloor;
    }
}