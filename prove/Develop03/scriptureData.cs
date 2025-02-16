public class ScriptureData
{
    public string VolumeTitle;
    public string BookTitle;
    public string ChapterNumber;
    public string VerseNumber;
    public string ScriptureText;

    public ScriptureData(string volumeTitle, string bookTitle, string chapterNumber, string verseNumber, string scriptureText)
    {
        VolumeTitle = volumeTitle;
        BookTitle = bookTitle;
        ChapterNumber = chapterNumber;
        VerseNumber = verseNumber;
        ScriptureText = scriptureText;
    }

    public string GetReference()
    {
        return $"{BookTitle.ToLower()} {ChapterNumber}:{VerseNumber}".ToLower();
    }
}
