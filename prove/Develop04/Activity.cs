using System;

public class Activity
{
    private string _activityName;
    private int _duration;
    private string _description;
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public string getActivityName()
    {
        return _activityName;
    }
    public string getDescription()
    {
        return _description;
    }
    public string setDuration(int duration)
    {
        _duration = duration;
        return "Your time has been set.";
    }
    public int getDuration()
    {
        return _duration;
    }
    public string getStart(string description)
    {
        return $"Welcome to the {_activityName} Activity. \n {description}\n How long, in seconds, would you like your session to be?";
    }

}