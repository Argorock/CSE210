using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class User
{
    private string _user;
    private string _username;
    // private string _plainText;
    private string _encrypted;    
    private string _decrypted;
    private string _place;
    List<Password> passwords = new List<Password>();


    public void ManagePasswords()
    {
        Console.Write("Who are you: ");
        _user = Console.ReadLine().ToLower();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Create a new password");
        Console.WriteLine("2. Encrypt an existing password");
        Console.WriteLine("3. Decrypt an existing password");
        Console.WriteLine("4. Display all passwords");
        Console.Write("Enter your choice (1-4): ");
        string choice2 = Console.ReadLine();

        switch (choice2)
        {
            case "1":
                CreateNewPassword();
                break;
            case "2":
                EncryptPassword();
                break;
            case "3":
                DecryptPassword();
                break;
            case "4":
                DisplayPasswords();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void CreateNewPassword()
    {
        Console.Write("Enter the place (e.g., walmart.com): ");
        string place = Console.ReadLine().ToLower();
        Console.Write("Enter the username: ");
        string username = Console.ReadLine().ToLower();

        Console.Write("Enter the length of the password to generate (8-30): ");
        int length = int.Parse(Console.ReadLine());


        string generatedPassword = CreatePassword.GeneratePassword(length);

        Encryption encryption = new Encryption(generatedPassword, 3, 5);
        string encryptedPassword = encryption.MultiStageEncrypt(generatedPassword);
        _encrypted = encryptedPassword;
        _username = username;
        _place = place;
        AddPassword();
    }

    private void EncryptPassword()
    {
        Console.Write("Enter the place (e.g., walmart.com): ");
        string place = Console.ReadLine().ToLower();
        Console.Write("Enter the username: ");
        string username = Console.ReadLine().ToLower();

        Console.Write("Enter the plain text password to encrypt: ");
        string plainText = Console.ReadLine();
        int length = plainText.Length;
        if (length < 8 || length > 30)
        {
            throw new ArgumentOutOfRangeException("Password length must be between 8 and 30 characters.");
        }
        Encryption encryption = new Encryption(plainText, 3, 5);
        string encryptedPassword = encryption.MultiStageEncrypt(plainText);
        // System.Console.WriteLine($"Final Encryption: {encryptedPassword}");
        _encrypted = encryptedPassword;
        _username = username;
        _place = place;
        AddPassword();
    }

    private void DecryptPassword()  
    {
        FileManager file = new FileManager();

        Console.Write("Please enter the password's place: ");
        string place = Console.ReadLine().ToLower();

        string encryptedPassword = file.LoadData(_user, place);
        
        string decryption = new Decryption(encryptedPassword, 3, 5).MultiStageDecrypt(encryptedPassword, "`1, 1, username");
        System.Console.WriteLine($"Decrypted: {decryption}");
    }


public void AddPassword()
{
    Password password = new Password(_place, _username, _encrypted);
    passwords.Add(password);
    FileManager file = new FileManager();
    file.SaveData(passwords, _user);

    Console.WriteLine("Password added successfully!");
    password.GetPasswordDetails();
}

public void DisplayPasswords()
{
    System.Console.WriteLine();
    string fileName = $"{_user}_passwords.txt";

    if (!File.Exists(fileName))
    {
        Console.WriteLine("No passwords found for this user.");
    }

    Console.WriteLine($"Passwords for {_user}:");

    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
}