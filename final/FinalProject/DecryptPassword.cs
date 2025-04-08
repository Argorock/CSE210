class Decryption : PasswordService 
{
    private string _encrypted;
    public Decryption(string encrypted, int initialShift, int secondaryShift) : base()
    {
        _encrypted = encrypted;
        _initialShift = initialShift;
        _secondaryShift = secondaryShift;
    }
    public string Decrypt()
{
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
    return decryptedPassword;
}
public string MultiStageDecrypt(string encryptedPassword, string metaData)
{

    _encrypted = encryptedPassword;
    string metadataPassword = Decrypt();
    // System.Console.WriteLine($"Meta Data Password: {metadataPassword}");
    string stage2 = new MetaData(0, 0).RemoveMetaData(metadataPassword, out metaData);

    string[] metaparts = metaData.Trim('`').Split(',');
    // Console.WriteLine($"Extracted metadata: {metaData}");
    // System.Console.WriteLine(metaparts[0]);
    // System.Console.WriteLine(metaparts[1]);
    int interval = int.Parse(metaparts[0]);
    int saltLength = int.Parse(metaparts[1]);

    // System.Console.WriteLine($"Stage2: {stage2}");
    _encrypted = stage2;
    string saltedPassword = Decrypt();
    // System.Console.WriteLine($"Salted Password: {saltedPassword}");
    string desaltedpassword = new Salt("", 0).RemoveSalt(saltedPassword, interval, saltLength);
    // System.Console.WriteLine($"desalted password: {desaltedpassword}");
    _encrypted = desaltedpassword;
    string stage3 = Decrypt();
    return stage3;
}
}