class Car : Vehicle
{
    private bool _seatFoldDown = false;

    public Car() : base()
    {

    }
    public Car(bool seatFoldDown) : base()
    {
        _seatFoldDown = seatFoldDown;
    }
}