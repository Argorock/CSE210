using System;

class Program
{
    static void Main(string[] args)
    {
        Password password = new Password("password", "", "metaData", 0);

        // Call the Encrypt method with a salted password
        string saltedPassword = "password123!"; // Example salted password
        string encryptedPassword = password.Encrypt(saltedPassword);
        string decryptedPassword = password.Decrypt(encryptedPassword);

        // Display the encrypted password
        Console.WriteLine("Salted Password: " + saltedPassword);
        Console.WriteLine("Encrypted Password: " + encryptedPassword);
        Console.WriteLine("Decrypted Password: " + decryptedPassword);
    }
}