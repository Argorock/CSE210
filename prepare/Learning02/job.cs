class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.Write($"{_jobTitle} ");
        Console.Write($"({_company}) ");
        Console.WriteLine($"{_startYear}-{_endYear}");
    }


}