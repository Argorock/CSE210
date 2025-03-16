class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetComplete()
    {
        _isComplete = true;
    }

    public override string Display()
    {
        return $"{_name}: {_description} - Points: {_points} - Complete: {_isComplete}";
    }

    public override string GetRep()
    {
        return $"SimpleGoal|{_name}:{_description}:{_points}:{_isComplete}";
    }

    public override void SetRep(int rep)
    {
        // Not applicable for SimpleGoal
    }

    public void SetRep(string rep)
    {
        // should turn all the data of the goal into a single string
        string[] parts = rep.Split(':');
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _isComplete = bool.Parse(parts[3]);
    }
}