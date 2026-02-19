using System;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
    
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Press Enter...");
                    Console.ReadLine();
                    continue;
            }

            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    CreateGoal();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    SaveGoals();
                    break;
                case 7:
                    LoadGoals();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"- {goal.ShortName}");
        }
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points, false);
                break;
            case 2:
                Console.WriteLine("Enter target count for checklist goal:");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points for completing the checklist goal:");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus, 0);
                break;
            case 3:
                newGoal = new EternalGoal(name, description, points);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully! Press Enter...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            Console.ReadLine();
            return;
        }

        ListGoalDetails();

        Console.Write("Which goal would you like to record? (Enter number): ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            Console.ReadLine();
            return;
        }

        Goal goal = _goals[index - 1];

        if (!goal.IsRecordable())
        {
            Console.WriteLine("This goal is already complete and cannot be recorded again.");
            Console.ReadLine();
            return;
        }

        bool wasIncomplete = !goal.IsComplete();

        goal.RecordEvent();

        int earned = goal.Points;

    
        if (goal is ChecklistGoal cg && wasIncomplete && cg.IsComplete())
        {
            earned += cg.Bonus;
            Console.WriteLine($"Bonus awarded: {cg.Bonus} points!");
        }

            _score += earned;
            Console.WriteLine($"You earned {earned} points! Total score: {_score}");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully! Press Enter...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Press Enter...");
            Console.ReadLine();
            return;
        }


        try
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length < 2) continue;
                    string type = parts[0];
                    string[] data = parts[1].Split(',');

                    Goal loadedGoal = null;
                    switch (type)
                    {
                        case "SimpleGoal":
                            if (data.Length >= 4)
                            {
                                loadedGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
                            }
                            break;
                        case "ChecklistGoal":
                            if (data.Length >= 6)
                            {
                                loadedGoal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                            }
                            break;
                        case "EternalGoal":
                            if (data.Length >= 3)
                            {
                                loadedGoal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                            }
                            break;
                        default:
                            Console.WriteLine($"Unknown type: {type}. Skipping.");
                            continue;
                    }

                    if (loadedGoal != null)
                    {
                        _goals.Add(loadedGoal);
                    }
                }
            }
            Console.WriteLine("Loaded! Press Enter...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading: {ex.Message}");
        }
        Console.ReadLine();
    }
}