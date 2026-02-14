using System;

class Activity
{
    private readonly string _name;
    private readonly string _description;
    protected int _duration;

    public string Name => _name;
    public string Description => _description;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Display()
    {
        Console.WriteLine($"Welcome to the {Name} Activity!");
        Console.WriteLine(Description);
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the duration.");
        }
        _duration = duration;
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void End(int duration)
    {
        Console.WriteLine($"Well done! You completed the {Name} Activity for {duration} seconds.");
        System.Threading.Thread.Sleep(5000);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            System.Threading.Thread.Sleep(250);
            Console.Write("\r   \r");
        }
    }
}