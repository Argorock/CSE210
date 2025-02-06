
    
//         Console.Write("What is the Magic Number ");
//         string stringNumber = Console.ReadLine();

//         int HighNumber = Int32.Parse(stringNumber);
//         Random randomGenerator = new Random();
//         int magicNumber = randomGenerator.Next(1,HighNumber);


//         bool validate = true;
//         Console.Write("What is your guess ");
//         while (validate == true)
//         {
//             string guess = Console.ReadLine();
//             int intguess = Int32.Parse(guess);
//             if (intguess < magicNumber)
//             {
//                 Console.WriteLine("Higher");
//             }
//             else if (intguess > magicNumber)
//             {
//                 Console.WriteLine("Lower");
//             }
//             else
//             {
//                 validate = false;
//             }
//             Console.WriteLine("Please try again: ");
            
//         }
//         Console.WriteLine("You guessed it!");


//         Console.WriteLine("=======================================================================");


//         List<int> numbers = new List<int>();
        
//         Console.WriteLine("Please choose some numbers to add to a list, enter 0 to quit ");
        
//         bool True = true;
//         while (True)
//         {
//             string strNumber = Console.ReadLine();
//             int number = Int32.Parse(strNumber);

//             numbers.Add(number);
//             if (number == 0)
//             {
//                 True = false;
//             }
//         }
        
        
//         foreach (int Number in numbers)
//         {
//             Console.WriteLine(Number);
//         }
//         double totalNum = numbers.Sum();
//         double avgNum = numbers.Average();
//         double maxNum = numbers.Max();
//         double minNum = numbers.Min();
//         Console.WriteLine();
//         Console.WriteLine(totalNum);
//         Console.WriteLine(avgNum);
//         Console.WriteLine(maxNum);
//         Console.WriteLine(minNum);
//         numbers.Sort();



// Console.WriteLine("===================================================================================");


//         displayWelcome();
//         string name = PromptUserName();
//         int favnumber = PromptUserNumber();
//         int SqrNumber = SquareNumber(favnumber);
//         DisplayResult(name, SqrNumber);
        
//         static void displayWelcome()
//         {
//             Console.WriteLine("Welcome to the program. ");
//         }

//         static string PromptUserName()
//         {
//             Console.WriteLine("Please enter your name: ");
//             string name = Console.ReadLine();
//             return name;
//         }

//         static int PromptUserNumber()
//         {
//             Console.WriteLine("Please enter your favorite number: ");
//             string strnum = Console.ReadLine();
//             int favnumber = Int32.Parse(strnum);
//             return favnumber;
//         }

//         static int SquareNumber(int favnumber)
//         {
//             int SqrNumber = favnumber * favnumber;
//             return SqrNumber;
//         }

//         static void DisplayResult(string name, int SqrNumber)
//         {
//             Console.WriteLine($"{name}, the square of your favorite number is : {SqrNumber}");
//         }