using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Password
{
    protected string _plainText;
    private string _encrypted;
    private string _metaData;
    private int _count;
    private string _decryptedPassword;

    private const int _initialShift = 3;
    private const int _secondaryShift = 5;
    private const int _positionDivider = 3;

    public Password(string plainText, string encrypted, string metaData, int count)
    {
        _plainText = plainText;
        _encrypted = encrypted;
        _metaData = metaData;
        _count = count;
    }



    public string Encrypt(string _saltedPassword)
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
        _encrypted = "";
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
                _encrypted += charSet[shiftedIndex];
            }
            else
            {
                _encrypted += character;
            }
        }
        return _encrypted;
    }
// char_set_length = len(char_set)
//     encrypted_password = ""
//     current_shift = INITIAL_SHIFT
//     secondary_current_shift = SECONDARY_SHIFT
//     position = len(salted_password) / POSITION_DIVIDER

//     for i, char in enumerate(salted_password):
//         if char in char_set:
//             if (i + 1) % position == 0:
//                 shift_amount = secondary_current_shift
//                 secondary_current_shift += 3
//             else:
//                 shift_amount = current_shift
//             char_index = char_set.find(char)
//             shifted_index = (char_index + shift_amount) % char_set_length
//             encrypted_password += char_set[shifted_index]
//             current_shift += 1
//         else:
//             encrypted_password += char
//     return encrypted_password









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
    public string Display()
    {
        return "Encrypted: " + _encrypted + "\n" +
               "Plain Text: " + _plainText + "\n" +
               "Meta Data: " + _metaData;
    }
}

