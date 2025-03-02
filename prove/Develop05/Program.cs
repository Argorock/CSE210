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
            Console.Clear();
                new BreathingActivity().Doactivity();
                break;
            case "2":
            Console.Clear();

                new ReflectionActivity().Doactivity();
                break;
            case "3":
            Console.Clear();

                new ListingActivity().Doactivity();
                break;
            case "4":
            Console.Clear();

                // new Activity().Doactivity();
                break;
            case "5":
            Console.Clear();

                Environment.Exit(0);
                break;
            default:
            Console.Clear();

                Console.WriteLine("Invalid input");
                break;
        }
        
        // new Activity().ShowAnimation();




















    }


}