class CreatePassword : PasswordService
{
    public static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        Random random = new Random();
        char[] passwordChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            passwordChars[i] = validChars[random.Next(validChars.Length)];
        }

        return new string(passwordChars);
    }

    public override void PasswordServices()
    {

    }
}