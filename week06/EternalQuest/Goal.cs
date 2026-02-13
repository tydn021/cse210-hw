using System;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
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
        return $"{checkbox} {_shortName} - {_description}";
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract string GetStringRepresentation();
}