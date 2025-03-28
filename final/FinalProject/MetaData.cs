class MetaData
{
    private string _password;
    private int _saltInterval;
    private int _saltLength;
    private string _username;

    public MetaData(string password, int saltInterval, int saltLength, string username)
    {
        _password = password;
        _saltInterval = saltInterval;
        _saltLength = saltLength;
        _username = username;
    }



    public string SaveData()
    {
        string metaData = $"Password: {_password}, Salt Interval: {_saltInterval}, Salt Length: {_saltLength}, Username: {_username}";
        return metaData;
    }
    public void GetData(string password, int saltInterval, int saltLength, string username)
    {
        _password = password;
        _saltInterval = saltInterval;
        _saltLength = saltLength;
        _username = username;
    }
}