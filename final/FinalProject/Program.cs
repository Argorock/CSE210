using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("JohnDoe");
        user.AddPassword();
        user.DisplayPasswords();

    

    }
}