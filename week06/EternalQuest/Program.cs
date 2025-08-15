using System;
class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine($"Score: {score} | Level: {score / 1000}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ListGoals(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string input = Console.ReadLine();

        Console.Write("What is the name of your goal ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of your goal ");
        string description = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("What is the amount of points associated with the points? ");
                int points = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                Console.Write("Enter points per completion: ");
                int ep = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, description, ep));
                break;
            case "3":
                Console.Write("Enter points per event: ");
                int cp = int.Parse(Console.ReadLine());
                Console.Write("Enter number of times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, cp, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select a goal to record (number): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal g = goals[i];
            Console.WriteLine($"{i + 1}. {g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(score);
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetSaveString());
            }
        }
        Console.WriteLine("Saved successfully.");
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(file);
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                Goal g = Goal.LoadFromString(lines[i]);
                goals.Add(g);
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
