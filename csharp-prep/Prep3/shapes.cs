class Shapes
{
    private string _color;

    public shapes()
    {
        _color = white;
    }

    public string GetColor()
    {
        return _color;
    }
    
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}