class PasswordService
{
    private const int _minLength = 8;
    private const int _maxLength = 30;
    
    protected int _initialShift;
    protected int _secondaryShift;
    protected int _positionDivider;
    protected int _count;
    
    public PasswordService()
    {
    _initialShift = 3;
    _secondaryShift = 5;
    _positionDivider = 2;
    _count = 1;
    }

    protected string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~";
}