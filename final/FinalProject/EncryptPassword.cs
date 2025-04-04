class Encryption : PasswordService
{
    private string _plainText;

public Encryption(string plainText, int initialShift, int secondaryShift) : base()
{
        _plainText = plainText;
        _initialShift = initialShift;
        _secondaryShift = secondaryShift;
}
public string Encrypt()
    {
        int charSetLen = charSet.Length;
        string encryptedPassword = "";
        int currentShift = _initialShift;
        int secondaryCurrentShift = _secondaryShift;

        int position = _plainText.Length / _positionDivider;
        
        for (int i = 0; i < _plainText.Length; i++)
        {
            char character = _plainText[i];
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
        return encryptedPassword;
    }
public string MultiStageEncrypt(string password)
{
    _plainText = password;
    string stage1 = Encrypt();
    // System.Console.WriteLine($"stage1: {stage1}");
    Salt saltHandler = new Salt(stage1, 1);
    string saltedPassword=saltHandler.AddSalt(stage1, out int interval, out int saltLength);
    // System.Console.WriteLine($"Salted Password: {saltedPassword}");
    MetaData metaDataHandler = new MetaData(interval, saltLength);
    string metaData = metaDataHandler.SaveMetaData();
    // System.Console.WriteLine($"Meta Data: {metaData}");
    _plainText = saltedPassword;
    string stage2 = Encrypt();
    // System.Console.WriteLine($"Stage2: {stage2}");
    string metadataPassword = stage2 + metaData;
    _plainText = metadataPassword;
    string stage3 = Encrypt();
    return stage3;
}
}
