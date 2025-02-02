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
        Console.Write("Please Choose a number (1-5): ");
        string choice = Console.ReadLine();
        int numChoice = int.Parse(choice);
        return numChoice;
    }
    public void DisplayMenu()
    {
        // Console.Write("Please choose an option(1-5): ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
    public void DisplayLogic(Journal journal, PromptMan promptMan)
    {
        bool done = false;
        while (done != true)
        {
            DisplayMenu();
            int numChoice = GetInput();
            switch (numChoice)
            {
                case 1:
                journal.AddEntry(promptMan);
                break;
                case 2:
                journal.DisplayEntries();
                break;

                case 3:
                
                break;

                case 4:
                
                break;

                case 5:
                Console.WriteLine("Goodbye");
                done = true;
                break;
                default:
                Console.WriteLine("Invalid option. Please try again: ");
                break;
            }
        }
    }



    static void Main(string[] args)
    {

        PromptMan promptMan = new PromptMan();
        Journal journal = new Journal();
        Program program = new Program();
        program.DisplayLogic(journal, promptMan);


    }
}