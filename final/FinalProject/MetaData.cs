class MetaData
{
    private int _saltInterval;
    private int _saltLength;
    public MetaData(int saltInterval, int saltLength)
    {

        _saltInterval = saltInterval;
        _saltLength = saltLength;
    }



    public string SaveMetaData()
    {
        string metaData = $"`{_saltInterval},{_saltLength}";
        return metaData;
    }

    public string RemoveMetaData(string input, out string metaData)
    {
        int metaDataStartIndex = input.IndexOf('`');
    
    if (metaDataStartIndex != -1)
    {
        metaData = input.Substring(metaDataStartIndex);
        return input.Substring(0, metaDataStartIndex);
    }
    metaData = "";
    return input;
    }
}
