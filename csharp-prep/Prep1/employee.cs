public abstract class Employee
{
    protected string _name;

    public Employee(string name)
    {
        _name = name;
    }

    // TODO - need method to calculate payday
    public abstract float SetPayDay();

    public virtual void display()
    {
        Console.WriteLine("Employee name: " + _name);
    }
}