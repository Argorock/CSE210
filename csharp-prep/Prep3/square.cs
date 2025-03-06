class Square : Shapes
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}