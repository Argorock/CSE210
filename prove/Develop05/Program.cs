using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        while (true)
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
                    Console.Clear();
                    break;
                case "2":
                Console.Clear();
                    new ReflectionActivity().Doactivity();
                    Console.Clear();
                    break;
                case "3":
                Console.Clear();
                    new ListingActivity().Doactivity();
                    Console.Clear();
                    break;
                case "4":
                Console.Clear();
                    new GratitudeActivity().Doactivity();
                    Console.Clear();
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
            System.Console.WriteLine("Would you like to do another activity? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                break;
            }
            else if (answer == "y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }       
    }
}