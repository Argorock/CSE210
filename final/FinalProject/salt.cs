class Salt 
{
    private List<char> letters =
            ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
    private List<char> numbers =
            ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    private List<char> specialCharacters =
            ['!', '#', '$', '%', '&', '(', ')', '*', '+',
            '-', '.', '/', ':', ';', '<', '=', '>', '?', '@',
            '[', ']', '_', '{', '|', '}', '~'];
    protected string _saltedPassword;
    protected int _interval;

    public Salt(string saltedPassword, int interval)
    {
        _saltedPassword = saltedPassword;
        _interval = interval;
    }

        public int RandomInterval()
    {
        Random random = new Random();
        int interval = random.Next(1, 10); // Random interval between 1 and 10
        return interval;
    }

    public int GetInterval()
    {
        return _interval;
    }
    public void SetInterval(int interval)
    {
        _interval = interval;
    }


    public string CreateSalt(string _plainText)
    {
        string salt = "";
        Random random = new Random();
        for (int i= 0; i < 4; i++)
        {
            int characterPicker = random.Next(1, 11);
            char character;
            if (characterPicker <= 6)
            {
                character = letters[random.Next(letters.Count)];
            }
            else if (characterPicker == 7 || characterPicker == 8)
            {
                character = numbers[random.Next(numbers.Count)];
            }
            else
            {
                character = specialCharacters[random.Next(specialCharacters.Count)];
            }
            salt = character + salt;
        }
        return salt;
    }
    public string AddSalt(string plainText, int interval)
    {
        string saltedPassword = "";
        int currentIndex = 0;

        while (currentIndex < plainText.Length)
        {
            int chunkLength = Math.Min(interval, plainText.Length - currentIndex);
            string chunk = plainText.Substring(currentIndex, chunkLength);

            saltedPassword += chunk;

            if (currentIndex + chunkLength < plainText.Length) 
            {
                saltedPassword += CreateSalt(plainText);
            }


            currentIndex += chunkLength;
        }

        return saltedPassword;
    
    }

    public string RemoveSalt(string saltedPassword, int interval)
    {
            string desaltedPassword = "";
        int currentIndex = 0;

        while (currentIndex < saltedPassword.Length)
        {
            // Extract a chunk of the plain text
            int chunkLength = Math.Min(interval, saltedPassword.Length - currentIndex);
            string chunk = saltedPassword.Substring(currentIndex, chunkLength);
            desaltedPassword += chunk;

            // Move past the chunk and the salt (4 characters of salt)
            currentIndex += chunkLength + 4; // 4 is the length of the salt
        }

        return desaltedPassword;
    }
}













    // rand_number = random.randint(1,5)
    // if rand_number == 1:
    //     return f"{salt},{first_half},{salt2},{second_half},{salt3},1"
    // elif rand_number == 2:
    //     return f"{salt},{second_half},{salt2},{first_half},{salt3},2"
    // elif rand_number == 3:
    //     return f"{salt3},{salt2},{first_half},{salt},{second_half},3"
    // elif rand_number == 4:
    //     return f"{second_half},{salt2},{salt3},{salt},{first_half},4"
    // elif rand_number == 5:
    //     return f"{first_half},{salt},{salt2},{second_half},{salt3},5"





    // """original_string = "Hello World"
    // trimmed_string = original_string[5:]
    // print(trimmed_string)  Output: ' World' """
    // desalted_password = salted_password.strip().split(",")
    // salt_key = desalted_password[-1]
    // if salt_key == "1":
    //     return f"{desalted_password[1]}{desalted_password[3]}"
    // elif salt_key == "2":
    //     return f"{desalted_password[3]}{desalted_password[1]}"
    // elif salt_key == "3":
    //     return f"{desalted_password[2]}{desalted_password[4]}"
    // elif salt_key == "4":
    //     return f"{desalted_password[4]}{desalted_password[0]}"
    // elif salt_key == "5":
    //     return f"{desalted_password[0]}{desalted_password[3]}"