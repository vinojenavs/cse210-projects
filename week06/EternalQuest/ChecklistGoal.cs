public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int total = GetPoints();
            if (_currentCount == _targetCount)
                total += _bonus;
            return total;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return IsComplete() ? $"[X] Completed {_currentCount}/{_targetCount}" : $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_bonus}|{_currentCount}";
    }
}
