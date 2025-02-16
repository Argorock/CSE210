using System;
using System.Collections.Generic;
using System.Linq;

class Verse
{
    private List<Words> _verse = new List<Words>();
    private string _reference;

    public Verse(string verseText, string reference)
    {
        _reference = reference;
        foreach (var word in verseText.Split(' '))
        {
            _verse.Add(new Words(word));
        }
    }

    public string verse()
    {
        return string.Join(" ", _verse.Select(w => w.word()));
    }

    public void DisplayVerse()
    {
        Console.WriteLine($"{_reference}: {verse()}");
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        var wordsToHide = _verse.Where(w => !w.IsHidden()).OrderBy(x => random.Next()).Take(count).ToList();
        foreach (var word in wordsToHide)
        {
            word.hideword();
        }
    }

    public int RemainingWordsCount()
    {
        return _verse.Count(w => !w.IsHidden());
    }

    public bool AllWordsHidden()
    {
        return _verse.All(w => w.IsHidden());
    }
}
