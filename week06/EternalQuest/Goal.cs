using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string GetStatus()
    {
        return "[ ]";
    }

    public virtual string GetSaveString()
    {
        return $"Goal|{_name}|{_description}|{_points}";
    }

    public static Goal LoadFromString(string data)
    {
        string[] parts = data.Split("|");
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "EternalGoal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "ChecklistGoal":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            default:
                return new Goal("Unknown", "Invalid data", 0);
        }
    }
    public string GetName() => _name;
    public string GetDescription() => _description;
}
