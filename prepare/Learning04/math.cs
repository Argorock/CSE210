class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;


public MathAssignment(string textBookSection, string problems, string _studentName, string _topic) : base(_studentName, _topic)
{
    _textBookSection = textBookSection;
    _problems = problems;
}

    public string GetHomeworkList(string _studentName, string _topic,string _textBookSection, string _problems)
    {
        return $"{_studentName} - {_topic}\n{_textBookSection} {_problems}";
    }
}