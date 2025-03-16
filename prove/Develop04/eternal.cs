class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override void SetComplete()
    {
        // Not applicable for EternalGoal
    }

    public override string Display()
    {
        return $"{_name}: {_description} - Points: {_points} - Complete: Never";
    }

    public override string GetRep()
    {
        return $"EternalGoal|{_name}:{_description}:{_points}";
    }

    public override void SetRep(int rep)
    {
        // Not applicable for EternalGoal
    }

    public void SetRep(string rep)
    {
        // should turn all the data of the goal into a single string
        string[] parts = rep.Split(':');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }
}