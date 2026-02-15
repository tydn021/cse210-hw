using System;
using System.Diagnostics;

public class Cycling : Activity
{
    private float _speed = 0;

    public Cycling(DateTime _date, float _length, float speed) : base(_date, _length)
    {

        _speed = speed;
    }

    public override float GetDistance()
    {
        return  (GetSpeed() * _length) / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_length} min): Distance: {GetDistance()} miles. Speed: {GetSpeed()}. Pace: {GetPace()} min per mile.";
    }
}