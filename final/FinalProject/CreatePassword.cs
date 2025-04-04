class CreatePassword : PasswordService
{
    public static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~";
        Random random = new Random();
        char[] passwordChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            passwordChars[i] = validChars[random.Next(validChars.Length)];
        }

        return new string(passwordChars);
    }
} 