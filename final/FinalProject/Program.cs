using System;

class Program
{
    static void Main(string[] args)
    {
        Password password = new Password("password", "", "metaData");

        Salt salt = new Salt("", 3);
        string plainText = "password123";

        salt.AddSalt(plainText);

        string saltedPassword = salt.AddSalt(plainText); // need to get the _interval variable here
        string dealtedPassword = salt.RemoveSalt(saltedPassword);

        Console.WriteLine("Plain Text: " + plainText);
        Console.WriteLine("Salted Password: " + saltedPassword);
        System.Console.WriteLine("Desalted Password: " + dealtedPassword);

    

    }
}