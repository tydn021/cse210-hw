using System;

public abstract class Activity
{
    protected DateTime _date;
    protected float _length = 0;
    
    public Activity(DateTime date, float length)
    {
        _date = date;
        _length = length;        
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract string GetSummary();
}