using System;

public class SimpleGoal : Goal
{
    //if it is complete it will be set to 1
    private float _complete = 0;
    private int _timesCompleted = 0;
    public override float getComplete()
    {
        return _complete;
    }

    public override void SetComplete(float complete)
    {
        _complete = complete;
    }
    public override float IsComplete()
    {
        return _complete;
    }
    
}