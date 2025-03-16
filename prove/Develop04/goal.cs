abstract class Goal
{
    private string _name;
    private string _description;
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
        // should return if the goal is complete, abstract function
    public abstract void SetComplete();
        // should set the goal to complete, abstract function

    public virtual void GetGoalPoints()
    {
        // depends on the type of goal and what the user says its worth, virtual function
        return _points;
    }

    public abstract string GetRep();
    
        // Should get the value of what the goal is, abstract function
    

    public abstract void SetRep(int rep);
        // Should set the value of what the goal is, abstract function
 

    public abstract void Display()
    {
        // Should display the goal, abtract function
    }
}