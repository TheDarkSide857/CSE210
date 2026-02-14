using System;

class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public int Display()
    {
        Console.WriteLine($"Welcome to the {Name} Activity!");
        Console.WriteLine(Description);
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the duration.");
        }
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5);
        return duration;
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