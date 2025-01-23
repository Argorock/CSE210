// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
        
//         // short x = 32544;
//         // for (int i = 0; i < 1000; i ++)
//         // {
//         //     x++;
//         //     Console.WriteLine(x);
//         // }
//         // Console.Write("What is your first name? ");
//         // string firstName = Console.ReadLine();
//         // Console.WriteLine(firstName);
//         int age = int.Parse("34");
//         Console.WriteLine(age);

//         age = 34;
//         if (age >= 18)
//         {
//             Console.WriteLine("Yes you can vote");
//         }
//         else
//         {
//             Console.WriteLine("No you cannot vote");
//         }
//         // (cond) ? true : false;
//         bool canVote = (age >= 18) ? true : false;
//         Console.WriteLine(canVote);
//         // python: can_vote = True if age >= 18 else False

//         // and = && or = || not = !

//         age = 12;
//         string firstName = "bob";

//         Console.WriteLine($"My name is {firstName}, and i am {age} years old");

//         int count = 0;
//         while (count < 10)
//         {
//             Console.WriteLine(count);
//             count++;
//         }

//         string choice;
//         do
//         {
//             Console.WriteLine("Enter q to quit");
//             choice = Console.ReadLine();
//         } while (choice != "q");

//         for (int i = 100; i < 106; i++)
//         {
//             Console.WriteLine(i);
//         }

//         string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//         foreach (string car in cars)
//         {
//             Console.WriteLine(car);
//         }

//         Random randomGenerator = new Random();
//         for (int i = 0; 1 < 10; i++)
//         {
//             int number = randomGenerator.Next(1, 1000001);
//             Console.WriteLine(number);
//         }

//         // int[] values = {1, 2, 3, 4 };

//         List<int> numbers = new List<int>();
//         Console.WriteLine(numbers.Count);

//         numbers.Add(1);
//         numbers.Add(10);
//         numbers.Add(100);

//         Console.WriteLine(numbers);
//         Console.WriteLine(string.Join(", ", numbers));
        
//         numbers.Reverse();
//         Console.WriteLine(string.Join(", ", numbers));
//         Console.WriteLine(string.Join(", ", numbers));

//         // static return_type function_name(arguments)
//         // {
//         //     stuff
//         // }

//         // noun = variable
//         // verb = function
//         static int AddTwoInts(int a, int b)
//         {
//             int answer = a + b;
//             return answer;
//         }

//         static void HelloWorld()
//         {
//             Console.WriteLine("Hello World");
//         }


//     }
// }