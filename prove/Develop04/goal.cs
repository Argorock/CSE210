abstract class Goal
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

    // Should return if the goal is complete
    public virtual bool IsComplete()
    {
        return false;
    }

    // Should set the goal to complete
    public abstract void SetComplete();

    // Should return the points for the goal
    public virtual int GetGoalPoints()
    {
        return _points;
    }

    // Should get the representation of the goal
    public abstract string GetRep();

    // Should set the value of what the goal is
    public abstract void SetRep(int rep);

    // Should display the goal
    public abstract string Display();
}