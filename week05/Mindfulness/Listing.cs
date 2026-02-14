using System;

class Listing : Activity
{
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public new void Display()
    {
        int duration = base.Display();
        Random rand = new Random();

        string[] prompts = {
            "When have you felt the Holy Ghost in your life?",
            "Who are some people that you appreciate?",
            "What are some of your personal strengths?",
            "What are some things you are grateful for?",
            "What are some of your favorite memories?",
            "What are some things that make you happy?",
            "What are some of your favorite places to go?",
            "What are some things you have accomplished that you are proud of?"
        };

        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(selectedPrompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, start listing as many responses as you can to the prompt. You may begin in:");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;
    
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                count++;
            }
        }
    
        Console.WriteLine($"You listed {count} items!");
        
        End(duration);
    }
}