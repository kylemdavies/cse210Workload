using System;

public class ChecklistGoal : Goal
{
    private float _complete = 0;
    private int _times = 0;

    public override int GetTimes()
    {
        return _times;
    }

    public override void SetTimes(int times)
    {
        _times = times;
    }
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
        return _complete/_times;
    }
}