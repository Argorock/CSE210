class Words{
    private string _word;
    private bool _hidden;

    public Words(string word)
    {
        _word = word;
        _hidden = false;
    }
    public bool hideword() // bool
    {
        _hidden = true;
        return _hidden;
    }
    public string word() //"text" probably string
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
        return _word;
    }
    public bool IsHidden()
    {
        return _hidden;
    }

}