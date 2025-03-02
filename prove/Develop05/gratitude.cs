class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public GratitudeActivity() : base("Gratitude", "This activity will help you focus on the positive aspects of your life by listing things you are grateful for.", 30)
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Who are the people in your life that you are grateful for?",
            "What experiences have you had recently that you are grateful for?",
            "What personal qualities or strengths are you grateful for?",
            "What simple pleasures are you grateful for?"
        };
        _items = new List<string>();
    }

    public void Doactivity()
    {
        DisplayIntro();
        PromptDuration();
        ShowGetReady();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _items.Add(item);
            }
        }

        Console.WriteLine($"You listed {_items.Count} things you are grateful for.");
        Console.WriteLine("Gratitude activity complete.");
    }
}