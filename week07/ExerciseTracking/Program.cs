using System;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2026, 2, 19), 30, 5.0),
            new Cycling(new DateTime(2024, 5, 7), 60, 20.0),
            new Swimming(new DateTime(2024, 5, 15), 45, 1.0)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}