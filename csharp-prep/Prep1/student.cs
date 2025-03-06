public class Student : Employee
{
    public Student(string name) : base(name)
    {
    }

    public override float SetPayDay()
    {
        return 0.02f;
    }

    public override void display()
    {
        Console.WriteLine("Student name: " + _name);
    }
}