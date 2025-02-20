class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string subject, string title) : base(studentName, subject)
    {
        _title = title;
    }

    public string GetWritingIformation()
    {
        return $"{_studentName} - {_topic}\n{_title} by {_studentName}";
    }
}