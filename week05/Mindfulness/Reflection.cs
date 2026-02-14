using System;
class Reflection : Activity
{
    public Reflection() : base("Reflection", "This activity will help you reflect on your thoughts and feelings. Take a moment to find a quiet and comfortable place to sit, and focus on the following prompt.")
    {
    }

    public new void Display()
    {
        base.Display();
        Random rand = new Random();

        string[] prompts = {
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a significant challenge.",
            "Think of a time when you made a positive impact on someone else's life.",
            "Think of a time when you achieved something you were really proud of.",
            "Think of a time when you showed great resilience in the face of adversity.",
            "Think of a time when you made a difficult decision that turned out well."
        };

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?"
        };

        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(selectedPrompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        End(_duration);
    }
}