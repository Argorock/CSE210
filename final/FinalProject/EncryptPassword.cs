class Encryption : PasswordService
{
public void Encrypt(string _saltedPassword, string _encrypted)
    {
        string charSet;
        if (_count == 0)
        {
            charSet ="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:.<>?/~";
        }
        else
        {
            charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~";
        }
        int charSetLen = charSet.Length;
        string encryptedPassword = "";
        int currentShift = _initialShift;
        int secondaryCurrentShift = _secondaryShift;

        int position = _saltedPassword.Length / _positionDivider;
        
        for (int i = 0; i < _saltedPassword.Length; i++)
        {
            char character = _saltedPassword[i];
            if (charSet.Contains(character))
            {
                int shiftAmount;
                if ((i + 1) % position == 0)
                {
                    shiftAmount = secondaryCurrentShift;
                    secondaryCurrentShift += 3;
                }
                else
                {
                    shiftAmount = currentShift;
                }
                currentShift += 1;
                int charIndex = charSet.IndexOf(character);
                int shiftedIndex = (charIndex + shiftAmount) % charSetLen;
                encryptedPassword += charSet[shiftedIndex];
            }
            else
            {
                encryptedPassword += character;
            }
        }
        _encrypted = encryptedPassword;
    }
}