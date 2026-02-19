using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        public override double GetDistance() => Distance;
        public override double GetSpeed() => Distance * 60 / Duration;
        public override double GetPace() => Duration / Distance;
        public override string GetTypeName() => "Swimming";

        public double Distance { get; }

        public Swimming(DateTime date, int duration, double distance) : base(date, duration)
        {
            Distance = distance;
        }
    }
}