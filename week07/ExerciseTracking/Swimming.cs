using System;
using System.Diagnostics;

public class Swimming : Activity
{
    private int _laps= 0;

    public Swimming(DateTime _date, float _length, int laps) : base(_date, _length)
    {

        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000.0f * 0.62f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / _length) * 60f;
    }

    public override float GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Swimming ({_length} min): Distance: {GetDistance()} miles. Speed: {GetSpeed()}. Pace: {GetPace(): 0.##} min per mile.";
    }
}