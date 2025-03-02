class BreathingActivity : Activity
{

public BreathingActivity() : base("Breathing", "Follow the prompts on when to breathe in and out. Try to focus on your breathing to relax and calm your brain.", 30)
{
}

public void Doactivity()
{
    DisplayIntro();
    PromptDuration();
    ShowGetReady();
    Console.Clear();

    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(_duration + 2);
    while (DateTime.Now < end)
    {
        BreatheCycle();
    }
    System.Console.WriteLine("Breathing Activity Complete!");
}

    public void BreatheCycle()
    {
        Console.Clear();
        Console.WriteLine(" : Breathe in...");
        // System.Threading.Thread.Sleep(1000);
        ShowAnimation();
        System.Console.WriteLine("Hold...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(" : Breathe out...");
        // System.Threading.Thread.Sleep(1000);
        ShowAnimation();
        Thread.Sleep(1000);
    }

}
