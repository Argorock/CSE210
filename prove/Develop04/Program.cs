using System;

class Program
{
    static void Main(string[] args)
    {
        // List<Goal> goals = new List<Goal>();

        public void Save(Goal goal)
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

            // should save the goals to a txt file
        public void LoadGoals()
        {
            foreach (Goal goal in goals)
            {
                goal.Print();
                //should pull the goal data from a txt file
            }
        }
    }
}