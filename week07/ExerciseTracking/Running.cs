using System;
using System.Diagnostics;

public class Running : Activity
{
    private float _distance = 0;

    public Running(DateTime _date, float _length, float distance) : base(_date, _length)
    {

        _distance = distance;
    }

    public override float GetDistance()
    {
        return  _distance;
    }

    public override float GetSpeed()
    {
        return (GetDistance()/_length) * 60f;
    }

    public override float GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Running ({_length} min): Distance: {GetDistance()} miles. Speed: {GetSpeed()}. Pace: {GetPace()} min per mile.";
    }
}