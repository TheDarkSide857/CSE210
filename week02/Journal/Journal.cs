using System;

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Prompt();
        Console.Write("Your response: ");
        string text = Console.ReadLine();
        Console.Write("Prompt used: ");
        string prompts = Console.ReadLine();
        Entry entry = new Entry(text, prompts);
        _entries.Add(entry);
    }
    public void Prompt()
    {
        string[] prompts = {
            "What are you grateful for today?",
            "Describe a challenge you faced recently.",
            "What is a goal you want to achieve this week?",
            "Write about a memorable moment from your day.",
            "What is something new you learned today?"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date}: {entry._text}|{entry._prompts}");
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._text}|{entry._prompts}");
            }
        }
        Console.WriteLine("Journal saved.");
    }
    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                DateTime date = DateTime.Parse(parts[0]);
                string text = parts[1];
                string prompts = parts[2];
                Entry entry = new Entry(text, prompts){ _date = date };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded.");
    }
}