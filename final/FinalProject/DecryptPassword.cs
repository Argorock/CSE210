class Decryption : PasswordService 
{
    public string Decrypt(string _encrypted)
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
    _decryptedPassword = "";
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
            _decryptedPassword += charSet[shiftedIndex];

            
            currentShift += 1;
        }
        else
        {
            
            _decryptedPassword += character;
        }
    }
    return _decryptedPassword;
}
}