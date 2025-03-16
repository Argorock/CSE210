class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public void Display()
    {
        // should display the goal
        return $"{_name}: {_description} -Points: {_points}";
    }
    public string GetRep()
    {
        // should get the value of what the goal is
        return $"{_name}:{_description}:{_points}";
    }
    public string SetRep()
    {
        // should set the value of what the goal is

    }


    // Et(n, d, pt)
    // {
    //     _name = n;
    //     _description = d;
    //     _points = pt;
    // }
    // Et(string)
}
    