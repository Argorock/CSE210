class Cart
{
    public string _name = "TBD";
    public List<Item> _items = new List<Item>();

    public void Display()
    {
        Console.WriteLine($"Welcome to {_name}");
        foreach (var item in _items)
        {
            // Item.Display();
        }
    }

    public void Add()
    {
        Item newItem = new Item();

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();
        newItem._name = name;

        Console.Write("Enter Amount: ");
        string amount = Console.ReadLine();
        newItem._amount = double.Parse(amount);
    }
}