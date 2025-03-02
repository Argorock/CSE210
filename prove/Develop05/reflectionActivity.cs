class ReflectionActivity : Activity
{
private List<string> _prompts;
private List<string> _questions;
private List<string> _written;

public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30)
{
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a significant challenge.",
            "Think of a time when you made a positive impact on someone's life.",
            "Think of a time when you learned something valuable about yourself.",
            "Think of a time when you achieved a personal goal.",
            "Think of a time when you showed kindness to a stranger.",
            "Think of a time when you stood up for what you believed in.",
            "Think of a time when you supported a friend in need.",
            "Think of a time when you made a difficult decision and it turned out well.",
            "Think of a time when you felt proud of yourself.",
            "Think of a time when you helped resolve a conflict."
        };
                _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _written = new List<string>();
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
    DateTime end = start.AddSeconds(_duration + 4);
    while (DateTime.Now < end)
    {
        Console.Clear();
        System.Console.WriteLine($" : {_prompts[promptIndex]}");
        System.Console.WriteLine();
        int questionIndex = random.Next(_questions.Count);
        _written.Add(_questions[questionIndex]);
        ShowAnimation();
        Console.WriteLine(_written[_written.Count - 1]);
        for (int i = 1; i < 11; i++)
        {
            Console.Write(".");
            if (i % 4 == 0)
            {
                Console.Write("\r    \r");
            }
            System.Threading.Thread.Sleep(1000);
        }
        
    }
    System.Console.WriteLine("Reflection Activity Complete!");
}
}