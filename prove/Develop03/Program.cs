using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {

        string baseDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        Console.WriteLine("Base Directory: " + baseDirectory);

        // Construct the file path using the project directory
        string filePath = Path.Combine(baseDirectory, "Develop03", "lds-scriptures.csv");

        // Print the file path to verify it
        Console.WriteLine("File path: " + filePath);




        var scriptureData = new List<ScriptureData>();

        using (var parser = new TextFieldParser(filePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;
            parser.ReadLine(); 

            while (!parser.EndOfData)
            {

                string[] fields = parser.ReadFields();
                scriptureData.Add(new ScriptureData(
                    fields[4],
                    fields[5],
                    fields[14],
                    fields[15],
                    fields[16]
                ));
            }
        }

        var scriptures = new Scripture(scriptureData);


        System.Console.WriteLine("Enter a scripture reference (ex. Genesis 1:1) ");
        string reference = Console.ReadLine().ToLower();

        if (!string.IsNullOrEmpty(reference))
        {
            var scripture = scriptures.SearchByReference(reference);
            if (scripture != null)
            {
                var referenceText = $"{scripture.BookTitle} {scripture.ChapterNumber}:{scripture.VerseNumber}";
                scriptures.AddVerse(scripture.ScriptureText, referenceText);
            }
            else
            {
                Console.WriteLine("Scripture reference not found. Adding a random scripture instead.");
                var random = new Random();
                var randomScripture = scriptureData[random.Next(scriptureData.Count)];
                var randomReferenceText = $"{randomScripture.BookTitle} {randomScripture.ChapterNumber}:{randomScripture.VerseNumber}";
                scriptures.AddVerse(randomScripture.ScriptureText, randomReferenceText);
            }
        }
        else
        {
            var random = new Random();
            var randomScripture = scriptureData[random.Next(scriptureData.Count)];
            var randomReferenceText = $"{randomScripture.BookTitle} {randomScripture.ChapterNumber}:{randomScripture.VerseNumber}";
            scriptures.AddVerse(randomScripture.ScriptureText, randomReferenceText);
        }

        while (!scriptures.IsFinished())
        {
            Console.Clear();
            scriptures.DisplayScripture();
            Console.WriteLine("Press enter to hide words: ");
            Console.ReadLine();
            scriptures.HideWords();
            if (scriptures.IsFinished())
            {
                break;
            }
        }
        Console.Clear();
        scriptures.DisplayScripture();
        Console.WriteLine("Have you memorized it yet? keep trying if you didn't quite get it.");
    }
}
