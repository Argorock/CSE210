class Salt : PasswordService
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
    protected int _saltLength;

    public Salt(string saltedPassword, int interval)
    {
        _saltedPassword = saltedPassword;
        _interval = interval;
        _saltLength = RandomSaltLength();
    }

        public int RandomInterval()
    {
        Random random = new Random();
        return random.Next(1, 3);
    }

    public int RandomSaltLength()
    {
        Random random = new Random();
        _saltLength = random.Next(3, 8);
        return _saltLength;
    }

    public string CreateSalt()
    {
        string salt = "";
        Random random = new Random();
        for (int i= 0; i < _saltLength; i++)
        {
            int charType = random.Next(3); 
            switch (charType)
            {
                case 0:
                    salt += letters[random.Next(letters.Count)];
                    break;
                case 1:
                    salt += numbers[random.Next(numbers.Count)];
                    break;
                case 2:
                    salt += specialCharacters[random.Next(specialCharacters.Count)];
                    break;
            }
        }
        return salt;
    }
    public string AddSalt(string plainText)
    {
        _interval = RandomInterval();
        string saltedPassword = "";
        int currentIndex = 0;

        while (currentIndex < plainText.Length)
        {
            int chunkLength = Math.Min(_interval, plainText.Length - currentIndex);
            string chunk = plainText.Substring(currentIndex, chunkLength);

            saltedPassword += chunk;

            if (currentIndex + chunkLength < plainText.Length) 
            {
                saltedPassword += CreateSalt();
            }


            currentIndex += chunkLength;
        }

        return saltedPassword;
    
    }

    public string RemoveSalt(string saltedPassword)
    {
        string desaltedPassword = "";
        int currentIndex = 0;

        while (currentIndex < saltedPassword.Length)
        {
            int chunkLength = Math.Min(_interval, saltedPassword.Length - currentIndex);
            string chunk = saltedPassword.Substring(currentIndex, chunkLength);
            desaltedPassword += chunk;

            currentIndex += chunkLength + _saltLength;
        }

        return desaltedPassword;
    }
}