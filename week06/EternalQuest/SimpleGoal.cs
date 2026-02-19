using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

     public SimpleGoal(string name, string description, int points)
        : this(name, description, points, false)
    {
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine($"You have completed the goal: {_shortName} and earned {_points} points!");
            return;
        }

        _isComplete = true;
        Console.WriteLine($"You have completed the goal: {_shortName}!");
    }
    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string check = _isComplete ? "[X]" : "[ ]";
        return $"{check} {GetBaseDetails()}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public bool JustCompleted() => _isComplete;
    public override bool IsRecordable() => !_isComplete;
}