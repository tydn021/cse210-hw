using System;
using System.Linq.Expressions;
using System.Net;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string shortName, string description, int points) : base (shortName, description, points)
    { }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int GetPoints()
    {
        if (_isComplete == false)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public void SetIsComplete(bool status)
    {
        _isComplete = status;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}