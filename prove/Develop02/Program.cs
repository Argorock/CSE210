using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
// call journal
// call promptman
// create main

public int GetInput()
{
        string choice = Console.ReadLine();
        int numChoice = int.Parse(choice);
        return numChoice;
}
public void DisplayMenu()
{
        Console.WriteLine("Please choose an option(1-5): ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
}
public void Display()
{
    DisplayMenu();
    int numChoice = GetInput();
    switch (numChoice)
    {
        case 1:
        // Journal
        // promptman
        break;

        case 2:
        // journal
        break;

        case 3:
        // journal
        break;

        case 4:
        // journal
        break;

        default:
        // 
        break;
    }
}



    static void Main(string[] args)
    {

        Program program = new Program();
        program.Display();


    }
}