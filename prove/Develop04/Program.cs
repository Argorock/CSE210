using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static string baseDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
    static string filePath = Path.Combine(baseDirectory, "Develop04", "goals.txt");

    
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create/Add Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Complete a Goal");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoalMenu();
                    break;
                case "2":
                    ViewGoals();
                    break;
                case "3":
                    CompleteGoal();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoalMenu()
    {
        Console.WriteLine("Choose a goal type to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Back to Main Menu");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                goals.Add(CreateSimpleGoal());
                break;
            case "2":
                goals.Add(CreateEternalGoal());
                break;
            case "3":
                goals.Add(CreateChecklistGoal());
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static SimpleGoal CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, description, points);
    }

    static EternalGoal CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, points);
    }

    static ChecklistGoal CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter the target count for the goal: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for the goal: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, targetCount, bonusPoints);
    }

    static void ViewGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    static void CompleteGoal()
    {
        Console.Write("Enter the name of the goal to complete: ");
        string name = Console.ReadLine();

        foreach (var goal in goals)
        {
            if (goal.Display().Contains(name))
            {
                goal.SetComplete();
                Console.WriteLine($"Goal '{name}' marked as complete. Points earned: {goal.GetGoalPoints()}");
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetRep()}|{goal.Display()}");
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
{
    goals.Clear();
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 2)
            {
                Console.WriteLine("Invalid line format: " + line);
                continue;
            }

            string type = parts[0];
            string[] goalData = parts[1].Split(':');

            if (goalData.Length < 3)
            {
                Console.WriteLine("Invalid goal data format: " + parts[1]);
                continue;
            }

            string name = goalData[0].Trim();
            string description = goalData[1].Trim();
            int points = int.Parse(goalData[2].Trim());

            switch (type)
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    if (goalData.Length < 6)
                    {
                        Console.WriteLine("Invalid checklist goal data format: " + parts[1]);
                        continue;
                    }
                    int completed = int.Parse(goalData[3].Trim());
                    int totalToComplete = int.Parse(goalData[4].Trim());
                    int bonusPoints = int.Parse(goalData[5].Trim());
                    var checklistGoal = new ChecklistGoal(name, description, points, totalToComplete, bonusPoints);
                    checklistGoal.SetRep($"{name}:{description}:{points}:{completed}:{totalToComplete}:{bonusPoints}");
                    goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine("Unknown goal type: " + type);
                    break;
                }
            }
        }
    }
}