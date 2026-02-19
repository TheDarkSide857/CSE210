using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        public override double GetDistance() => Distance;
        public override double GetSpeed() => Distance * 60 / Duration;
        public override double GetPace() => Duration / Distance;
        public override string GetTypeName() => "Cycling";
        
        public double Distance { get; }

        public Cycling(DateTime date, int duration, double distance) : base(date, duration)
        {
            Distance = distance;
        }
    }
}