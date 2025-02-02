using System;

class Entry
{

    public DateTime _date;
    public string _prompt;
    public string _text;
    public Entry(string prompt)
    {
       _date = DateTime.Now; 
       _prompt = prompt;    
        Console.WriteLine($"Date: {_date} ");
        Console.Write($"Prompt {prompt} ");
        Console.Write("Entry: ");
        _text = Console.ReadLine();


    }
}