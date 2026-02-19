using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"You have completed the goal: {_shortName} and earned {_points} points!");
    }
    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[] {GetBaseDetails()}";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
    public override bool IsRecordable() => true;
}