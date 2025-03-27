using System;

class Program
{
    static void Main(string[] args)
    {
        Password password = new Password("password", "", "metaData");

        Salt salt = new Salt("", 3);
        string plainText = "password123";
        int interval = 3;

        salt.AddSalt(plainText, interval);

        string saltedPassword = salt.AddSalt(plainText, interval);
        string dealtedPassword = salt.RemoveSalt(saltedPassword, interval);

        Console.WriteLine("Plain Text: " + plainText);
        Console.WriteLine("Salted Password: " + saltedPassword);
        System.Console.WriteLine("Desalted Password: " + dealtedPassword);

    

    }
}