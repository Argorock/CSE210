class Checklist : Goal
{
    private int _completed;
    private int _totalToComplete;
    private int _bonusPoints;

    public Checklist(string name, string description, int points) : base(name, description, points)
    {
        _completed = 0;
        _totalToComplete = 0;
        _bonusPoints = 0;
    }
    public void Display()
    {
        // should display the goal
        return $"{_name}: {_description} -Points: {_points} - Completed: {_completed}/{_totalToComplete} - Bonus Points: {_bonusPoints}";
    }
    public string GetRep()
    {
        // should get the value of what the goal is
        return $"{_name}:{_description}:{_points}:{_completed}:{_totalToComplete}:{_bonusPoints}";
    }
    public string SetRep()
    {
        // should set the value of what the goal is

    }  
    public void IsComplete()
    {
        // should return if the goal is complete
        while (_completed < _totalToComplete)
        {
            _completed += 1;

        }
        if (_completed == _totalToComplete)
            return true;
    }
    public void SetComplete()
    {
        // should set the goal to complete
        
    }
    public void GetGoalPoints()
    {
        // depends on the type of goal and what the user says its worth
        return _points;
        if (_completed == _totalToComplete)
        {
            return _points + _bonusPoints;

        }
    }

//     CG(n, d, pt, fpt)
//     {
//         _name = n;
//         _description = d;
//         _points = pt;
//         _totalToComplete = 0;
//         _finishPoint = fpt;
//     }
//     cg(string)
}