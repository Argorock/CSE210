class Decryption : PasswordService 
{
    public void Decrypt(string _encrypted, string _plainText)
{
    string charSet;
    if (_count == 0)
    {
        charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:.<>?/~";
    }
    else
    {
        charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()-_=+[]{}|;:,.<>?/~";
    }
    int charSetLen = charSet.Length;
    string decryptedPassword = "";
    int currentShift = _initialShift;
    int secondaryCurrentShift = _secondaryShift;

    int position = _encrypted.Length / _positionDivider;

    for (int i = 0; i < _encrypted.Length; i++)
    {
        char character = _encrypted[i];
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

            
            int charIndex = charSet.IndexOf(character);
            int shiftedIndex = (charIndex - shiftAmount + charSetLen) % charSetLen; // Ensure positive index
            decryptedPassword += charSet[shiftedIndex];

            
            currentShift += 1;
        }
        else
        {
            
            decryptedPassword += character;
        }
    }
    _plainText = decryptedPassword;
}
}