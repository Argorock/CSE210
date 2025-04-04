using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Password
{
    private string _username;
    private string _encrypted;
    private string _place;



    public Password(string place, string username, string encrypted)
    {
        _encrypted = encrypted;
        _username = username;
        _place = place;

    }

    public string Display()
    {
    return $"Place: {_place}, Username: {_username}, Encrypted Password: {_encrypted}";    }
}

