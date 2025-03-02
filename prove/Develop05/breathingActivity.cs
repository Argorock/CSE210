class BreathingActivity : Activity
{
public BreathingActivity() : base("Breathing", "Breathing Activity", 30)
{
}

public void Doactivity()
{
    DisplayIntro();
    PromptDuration();
    ShowGetReady();
    // ShowCountDown(_duration);
    // ShowAnimation(_duration);
}
}