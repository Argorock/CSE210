class Simple : Goal
{
    private bool _isComplete;
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void IsComplete()
    {
        // should change the _complete bool to true
        return _isComplete;
    }
    public override void SetComplete()
    {
        _isComplete = true;
    }
    public void Display()
    {
        // should display goals
        return $"{_name}: {_description} -Points: {_points} - Complete: {_isComplete}";
    }

    public string GetRep()
    {
        return $"{_name}:{_description}:{_points}:{_isComplete}";
    }

    public string SetRep()
    {
        // should turn all the data of the goal into a single string
    }
    
    // sg(n, d, pt)
    // {
    //     _name = n;
    //     _description = d;
    //     _points = pt;
    // }
    
    // sg(string)
}