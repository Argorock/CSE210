class User
{
    private string _username;
    private string _user;
    // private string _plainText;
    private string _encrypted;    
    private string _decrypted;
    private string _place;
    List<Password> passwords = new List<Password>();
    private static List<User> users = new List<User>();

    public User(string user)
    {
        _user = user;
    }

    public string GetUsername()
    {
        return _user;
    }

    public static User FindUser(string username)
    {
        foreach (var user in users)
        {
            if (user.GetUsername() == username)
            {
                return user;
            }
        }
        return null;
    }


    public void ManageUsers()
    {
                System.Console.WriteLine("Please choose your user: ");
        System.Console.WriteLine("Existing User:");
        System.Console.WriteLine("New User:");
        string choice1 = Console.ReadLine();
        switch (choice1)
        {
            case "Existing User":
                Console.Write("Enter your username: ");
                _user = Console.ReadLine();
                User existingUser = FindUser(_user);
                if (existingUser != null)
                {
                    ManagePasswords();
                }
                else
                {
                    Console.WriteLine("User not found. Please try again.");
                    return;
                }
                break;
            case "New User":
                Console.Write("Enter a new username: ");
                _user = Console.ReadLine();
                CreateUser(_user);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }
        
        _user = Console.ReadLine();
    }
    public static void CreateUser(string user)
    {
        User newUser = new User(user);
        users.Add(newUser);
        Console.WriteLine($"User '{user}' created successfully!");
        newUser.ManagePasswords();
    }



    public void ManagePasswords()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Create a new password");
        Console.WriteLine("2. Encrypt an existing password");
        Console.WriteLine("3. Decrypt an existing password");
        Console.Write("Enter your choice (1/2/3): ");
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
                DecryptPassword("");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void CreateNewPassword()
    {
        Console.Write("Enter the length of the password to generate (8-30): ");
        int length = int.Parse(Console.ReadLine());


        string generatedPassword = CreatePassword.GeneratePassword(length);

        Encryption encryption = new Encryption(generatedPassword, 3, 5);
        string encryptedPassword = encryption.MultiStageEncrypt(generatedPassword);
        _encrypted = encryptedPassword;
        AddPassword();
    }

    private void EncryptPassword()
    {
        Console.Write("Enter the place (e.g., walmart.com): ");
        string place = Console.ReadLine();
        Console.Write("Enter the username: ");
        string username = Console.ReadLine();

        Console.Write("Enter the plain text password to encrypt: ");
        string plainText = Console.ReadLine();
        Encryption encryption = new Encryption(plainText, 3, 5);
        string encryptedPassword = encryption.MultiStageEncrypt(plainText);
        // System.Console.WriteLine($"Final Encryption: {encryptedPassword}");
        _encrypted = encryptedPassword;
        _username = username;
        _place = place;
        AddPassword();
    }

    private void DecryptPassword(string encryptedPassword)
    {
        string decryption = new Decryption(encryptedPassword, 3, 5).MultiStageDecrypt(encryptedPassword, "`1, 1, username");
        System.Console.WriteLine($"Decrypted: {decryption}");

    }


public void AddPassword()
{
    Password password = new Password(_place, _username, _encrypted);
    passwords.Add(password);

    Console.WriteLine("Password added successfully!");
    password.Display();
}

    public void RemovePassword(Password password)
    {
        passwords.Remove(password);
    }
public void DisplayPasswords()
{
    if (passwords.Count == 0)
    {
        Console.WriteLine("No passwords stored.");
        return;
    }

    Console.WriteLine("Passwords:");
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