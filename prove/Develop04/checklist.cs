class ChecklistGoal : Goal
{
    private int _completed;
    private int _totalToComplete;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int totalToComplete, int bonusPoints) : base(name, description, points)
    {
        _completed = 0;
        _totalToComplete = totalToComplete;
        _bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return _completed >= _totalToComplete;
    }

    public override void SetComplete()
    {
        _completed++;
    }

    public override int GetGoalPoints()
    {
        if (IsComplete())
        {
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override string Display()
    {
        return $"{_name}: {_description} - Points: {_points} - Completed: {_completed}/{_totalToComplete} - Bonus Points: {_bonusPoints}";
    }

    public override string GetRep()
    {
        return $"ChecklistGoal|{_name}:{_description}:{_points}:{_completed}:{_totalToComplete}:{_bonusPoints}";
    }

    public override void SetRep(int rep)
    {
        // Not applicable for ChecklistGoal
    }

    public void SetRep(string rep)
    {
        // should turn all the data of the goal into a single string
        string[] parts = rep.Split(':');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _completed = int.Parse(parts[3]);
        _totalToComplete = int.Parse(parts[4]);
        _bonusPoints = int.Parse(parts[5]);
    }
}