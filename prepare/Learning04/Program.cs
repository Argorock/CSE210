using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("John Doe", "Math");
        // string summary = assignment.GetSummary("Roberto Rodriguez", "Fractions");
        // Console.WriteLine(summary);

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "problems 8-19");
        string mathsummary = math.GetHomeworkList("Roberto Rodriguez", "Fractions", "Section 7.3", "problems 8-19");
        System.Console.WriteLine(mathsummary);

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingsummary = writing.GetWritingIformation();
        System.Console.WriteLine(writingsummary);
    }
}