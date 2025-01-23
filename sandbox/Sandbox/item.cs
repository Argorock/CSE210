class Item
{
    // variables
    public string _name;
    public double _amount;
    public bool _checked;

    public void Display()
    {
        Console.WriteLine($"{_name}, {_amount}, {_checked}");
    }
}