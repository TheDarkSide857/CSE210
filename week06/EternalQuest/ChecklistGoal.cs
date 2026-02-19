using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : this(name, description, points, target, bonus, 0)
    {
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public int Bonus => _bonus;

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You have already completed the goal: {_shortName}.");
            return;
        }

        _amountCompleted++;
        Console.WriteLine($"You have completed part of the goal: {_shortName}. Current progress: {_amountCompleted}/{_target}.");

        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have completed the goal: {_shortName}!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {GetBaseDetails()} - Progress: {_amountCompleted}/{_target} (Bonus: {_bonus} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public bool JustCompleted() => _amountCompleted == _target;
}