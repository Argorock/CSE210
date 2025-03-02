using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public ListingActivity() : base("Listing", "You'll be given a prompt to follow. write down as many answers to the prompt as you can", 30)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _items = new List<string>();
    }

    public void Doactivity() // : base()
    {
    DisplayIntro();
    PromptDuration();
    ShowGetReady();

    Random random = new Random();
    int promptIndex = random.Next(_prompts.Count);
    Console.WriteLine(_prompts[promptIndex]);

    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(_duration + 5);
    while (DateTime.Now < end);
    {
        while (DateTime.Now < end)
        {
            string item = System.Console.ReadLine();
            _items.Add(item);
        }
    }
    }
}