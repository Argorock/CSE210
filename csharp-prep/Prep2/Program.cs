using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentage);
        string letter = "";
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}");
        if (gradePercent >= 70)
        {
            Console.WriteLine("You Passed, nice job! ");
        }
        else
        {
           Console.WriteLine("Try again next time"); 
        }
        


    }

}