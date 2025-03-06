public class TA : Faculty
{
    public TA(string name) : base(name)
    {
    }

    public override float SetPayDay()
    {
        return 222.43f;
    }
    public override void display()
    {
        Console.WriteLine("TA name: " + _name);
    }
}