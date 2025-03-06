public class Faculty : Employee
{
    public Faculty(string name) : base(name)
    {

    }

    public override float SetPayDay()
    {
        return 333.54f;
    }

    public override void display()
    {
        Console.WriteLine("Faculty name: " + _name);
    }
}