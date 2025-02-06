using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
    // var rect = new Rectangle(width 100, height 200); //default
    // rect.Display();

    // rect.setWidth();
    // rect.setHeight();
    // rect.Display();

    // double area = rect.GetArea();
    // Console.WriteLine("Area of Rectangle: " + area);

    // rect.

    Fraction frac1 = new Fraction();
    Fraction frac2 = new Fraction(6);
    Fraction frac3 = new Fraction(6, 7);

    frac1.SetNumerator(3);
    frac1.SetDenominator(4);

    Console.WriteLine($"Fraction 1: {frac1.GetFractionString()} = {frac1.GetDecimalValue()}");
    Console.WriteLine($"Fraction 2: {frac2.GetFractionString()} = {frac2.GetDecimalValue()}");
    Console.WriteLine($"Fraction 3: {frac3.GetFractionString()} = {frac3.GetDecimalValue()}");

    frac3.SetNumerator(1);
    frac3.SetDenominator(3);
    Console.WriteLine($"Modified Fraction 3: {frac3.GetFractionString()} = {frac3.GetDecimalValue()}");
    }
}