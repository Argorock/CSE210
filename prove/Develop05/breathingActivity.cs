class BreathingActivity : Activity
{
public void Breathing() : base()
{
    // _name = "Breathing";
    // _description = "Breathing activity";
}

public void Doactivity()
{
    DisplayIntro();
    PromptDuration();
    ShowGetReady();
    ShowCountDown(_duration);
    ShowAnimation(_duration);
}