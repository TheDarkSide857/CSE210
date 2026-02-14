using System;

class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public new void Display()
    {
        base.Display();
        Console.WriteLine("Follow the prompts to breathe in and out slowly.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }

        End(_duration);
    }
}