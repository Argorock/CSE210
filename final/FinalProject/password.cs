using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Password
{
    protected string _plainText;
    private string _encrypted;
    private string _metaData;


    public Password(string plainText, string encrypted, string metaData)
    {
        _plainText = plainText;
        _encrypted = encrypted;
        _metaData = metaData;
    }

    public string Display()
    {
        return "Encrypted: " + _encrypted + "\n" +
               "Plain Text: " + _plainText + "\n" +
               "Meta Data: " + _metaData;
    }
}

