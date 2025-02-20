using System.Drawing;

public class Account
{
    private string _name;
    private int _balance;
    private double _rate;
    public Account()
    {
        _name = "";
        _balance = 0;
        _rate = 0;
    }

    public Account(string name, int balance, double rate)
    {
        _name = name;
        _balance = balance;
        _rate = rate;
    }
}

