class User
{
    private string _username;
    List<Password> passwords = new List<Password>();

    public User(string username)
    {
        _username = username;
    }

    public string GetUsername()
    {
        return _username;
    }

    public void AddPassword()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Create a new password");
        Console.WriteLine("2. Encrypt an existing password");
        Console.WriteLine("3. Decrypt an existing password");
        Console.Write("Enter your choice (1/2/3): ");
        string choice = Console.ReadLine();

        switch (choice)
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
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void CreateNewPassword()
    {
        Console.Write("Enter the length of the password to generate: ");
        int length = int.Parse(Console.ReadLine());


        string generatedPassword = CreatePassword.GeneratePassword(length);


        Salt salt = new Salt("", 3);
        string saltedPassword = salt.AddSalt(generatedPassword);


        Password password = new Password(generatedPassword, saltedPassword, $"SaltLength:{salt.GetSaltLength()}, Interval:{salt.RandomInterval()}");

        passwords.Add(password);

        Console.WriteLine("Generated and salted password added successfully!");
    }

    private void EncryptPassword()
    {
        Console.Write("Enter the plain text password to encrypt: ");
        string plainText = Console.ReadLine();


        Salt salt = new Salt("", 3);
        string saltedPassword = salt.AddSalt(plainText);


        Encryption encryption = new Encryption();
        string encryptedPassword = encryption.Encrypt(saltedPassword);


        Password password = new Password(plainText, encryptedPassword, $"SaltLength:{salt.GetSaltLength()}, Interval:{salt.RandomInterval()}");


        passwords.Add(password);

        Console.WriteLine("Password encrypted and added successfully!");
    }

    private void DecryptPassword()
    {
        Console.Write("Enter the encrypted password to decrypt: ");
        string encryptedPassword = Console.ReadLine();


        Decryption decryption = new Decryption();
        string saltedPassword = decryption.Decrypt(encryptedPassword);


        Salt salt = new Salt("", 3); 
        string plainText = salt.RemoveSalt(saltedPassword);

        Console.WriteLine("Decrypted password: " + plainText);
    }

    public void RemovePassword(Password password)
    {
        passwords.Remove(password);
    }
    public void DisplayPasswords()
    {
        foreach (var password in passwords)
        {
            Console.WriteLine(password.Display());
        }
    }
    public void ChangePassword(Password oldPassword, Password newPassword)
    {
        int index = passwords.IndexOf(oldPassword);
        if (index != -1)
        {
            passwords[index] = newPassword;
        }
    }
}