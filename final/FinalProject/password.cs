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

    public string GetPasswordDetails()
    {
    return $"{_place}:{_username}:{_encrypted}";
    }

    public bool MatchesPlace(string place)
{
    return _place.Equals(place, StringComparison.OrdinalIgnoreCase);
}

}

