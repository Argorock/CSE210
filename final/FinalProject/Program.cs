using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            User user = new User();
            user.ManagePasswords();
            Console.WriteLine("Do you want to continue? (y/n)");
            string continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "y")
            {
                break;
            }
        }

    

    }
}