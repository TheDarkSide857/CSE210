using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        public DateTime Date { get; }
        public int Duration { get; }

        protected Activity(DateTime date, int duration)
        {
            Date = date;
            Duration = duration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public abstract string GetTypeName();

        public virtual string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {GetTypeName()} ({Duration} min): Distance {GetDistance()} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }
    }
}