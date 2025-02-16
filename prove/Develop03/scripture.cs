using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    private List<ScriptureData> _scripturesData;

    public Scripture(List<ScriptureData> scripturesData)
    {
        _scripturesData = scripturesData;
    }

    public void AddVerse(string verseText, string reference)
    {
        _verses.Add(new Verse(verseText, reference));
    }

    public void DisplayScripture()
    {
        foreach (var verse in _verses)
        {
            verse.DisplayVerse();
        }
    }

    public void HideWords()
    {
        foreach (var verse in _verses)
        {
            int wordsToHide = 3;
            if (verse.RemainingWordsCount() < 3)
            {
                wordsToHide = verse.RemainingWordsCount();
            }
            verse.HideRandomWords(wordsToHide);
        }
    }

    public bool IsFinished()
    {
        return _verses.All(v => v.AllWordsHidden());
    }

    public ScriptureData SearchByReference(string reference)
    {
        reference = reference.ToLower();
        return _scripturesData.FirstOrDefault(s => s.GetReference() == reference);
    }
}
