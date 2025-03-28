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
        System.Console.Write("Please enter your Password: ");
        string plainText = Console.ReadLine();
        Salt salt = new Salt("", 3);
        string saltedPassword = salt.AddSalt(plainText);
        Password password = new Password(plainText, saltedPassword, "metaData");
        passwords.Add(password);

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