class ListingActivity : Activity
{
    List<string> _prompts;
    List<string> _items;

    public void Doactivity() : base()
    {
        DisplayIntro();
        PromptDuration();
        ShowGetReady();
        ShowCountDown(_duration);
        ShowAnimation(_duration);
    }
}