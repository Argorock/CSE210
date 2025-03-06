using System;

class Program
{
    static void Main(string[] args)
    {
        Shapes square = new Shapes();
        square.SetColor("red");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    }
}