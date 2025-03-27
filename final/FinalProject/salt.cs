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

    public Salt(string saltedPassword)
    {
        _saltedPassword = saltedPassword;
    }


    public string CreateSalt(string _plainText)
    {
        int numberOfCharacters = _plainText.Length / 2;
        string salt = "";
        Random random = new Random();
        while (numberOfCharacters != 0)
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
            numberOfCharacters -= 1;
        }
        return salt;
    }
    public void AddSalt(string _plainText)
    {
        string salt = CreateSalt(_plainText);
        string salt2 = CreateSalt(_plainText);
        string salt3 = CreateSalt(_plainText);
        string firstHalf = _plainText.Substring(0, _plainText.Length / 2);
        string secondHalf = _plainText.Substring(1, _plainText.Length / 2);
        Random random = new Random();
        int rand_number = random.Next(1, 6);
        if (rand_number == 1)
            _saltedPassword = $"{salt},{firstHalf},{salt2},{secondHalf},{salt3},1";
        else if (rand_number == 2)
            _saltedPassword = $"{salt},{secondHalf},{salt2},{firstHalf},{salt3},2";
        else if (rand_number == 3)
            _saltedPassword = $"{salt3},{salt2},{firstHalf},{salt},{secondHalf},3";
        else if (rand_number == 4)
            _saltedPassword = $"{secondHalf},{salt2},{salt3},{salt},{firstHalf},4";
        else
            _saltedPassword = $"{firstHalf},{salt},{salt2},{secondHalf},{salt3},5";
    }

    public void RemoveSalt(string saltedPassword)
    {
        string[] desaltedPassword = saltedPassword.Trim().Split(",");
        string saltKey = desaltedPassword[desaltedPassword.Length - 1];
        if (saltKey == "1")
            _saltedPassword = $"{desaltedPassword[1]}{desaltedPassword[3]}";
        else if (saltKey == "2")
            _saltedPassword = $"{desaltedPassword[3]}{desaltedPassword[1]}";
        else if (saltKey == "3")
            _saltedPassword = $"{desaltedPassword[2]}{desaltedPassword[4]}";
        else if (saltKey == "4")
            _saltedPassword = $"{desaltedPassword[4]}{desaltedPassword[0]}";
        else
            _saltedPassword = $"{desaltedPassword[0]}{desaltedPassword[3]}";
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