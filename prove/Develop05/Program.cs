using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Unkown Activity");
        Console.WriteLine("5. Exit");

        Console.Write("Enter the number of the activity you would like to do: ");
        //chooseActivity = Console.ReadLine();


        switch //chooseActivity = Convert.ToInt32()
        (Console.ReadLine())
        {
            case "1":
                new BreathingActivity().Doactivity();
                break;
            case "2":
                new ReflectionActivity().Doactivity();
                break;
            case "3":
                new ListingActivity().Doactivity();
                break;
            case "4":
                // new Activity().Doactivity();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        
        new Activity().ShowAnimation();




















    }


}