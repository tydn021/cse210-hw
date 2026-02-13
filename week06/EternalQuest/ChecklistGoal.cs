using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;

        _target = target;

        _bonus = bonus;
    }

     public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        
        _target = target;

        _bonus = bonus;
    }
    public override void RecordEvent()
    {

        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        string checkbox = "";
        bool i = IsComplete();
        if (i == true)
        {
            checkbox = "[X]";
        }
        else if (i == false)
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} - {_description} - Currently Completed: {_amountCompleted}/{_target} ";
    }

    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }

        else
        {
            return _points;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}