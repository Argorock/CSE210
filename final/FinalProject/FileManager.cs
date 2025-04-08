class FileManager
{
public void SaveData(List<Password> passwords, string username)
{
    string fileName = $"{username}_passwords.txt";
    Console.WriteLine($"Saving data to: {fileName}"); // Debugging

    using (StreamWriter writer = new StreamWriter(fileName, true))
    {
        foreach (var password in passwords)
        {
            Console.WriteLine($"Writing: {password.GetPasswordDetails()}");
            writer.WriteLine(password.GetPasswordDetails());
        }
    }
}


public string LoadData(string username, string place)
{
    string fileName = $"{username}_passwords.txt";

    if (!File.Exists(fileName))
    {
        Console.WriteLine("No passwords found for this user.");
        return null;
    }

    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(':');
            if (parts.Length >= 3)
            {
                Password tempPassword = new Password(parts[0], parts[1], parts[2]);

                if (tempPassword.MatchesPlace(place)) 
                {
                    return parts[2].Trim(); 
                }
            }
        }
    }

    Console.WriteLine("Error: No passwords found for that place.");
    return null;
}
}