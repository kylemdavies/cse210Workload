using System;

public class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points = 0;

    public Goal()
    {
    }

    public string GetGoalType()
    {
        return _type;
    }
    public void SetGoalType(string type)
    {
        _type = type;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    
    private float _complete = 0;

    public virtual void SetComplete(float complete)
    {
        _complete = complete;
    }
    public virtual float IsComplete()
    {
        return 0;
    }

    private int _times = 0;

    public virtual int GetTimes()
    {
        return _times;
    }

    public virtual void SetTimes(int times)
    {
        _times = times;
    }
    public virtual float getComplete()
    {
        return 0;
    }

}