using System.Security.Cryptography.X509Certificates;

class Activity
{
    private int _duration;
    private string _name;
    private string _description;

    Activity()
    {
        _name = "Unknown";
        _description = "Unknown";
    }
    public Activity(string name, string description,)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.WriteLine("Welcome to the activity: " + _name);
        Console.WriteLine("Description: " + _description);
    }
    public void PromptDuration()
    {
        Console.WriteLine("Please enter the duration of the activity in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        
    }
    public void ShowGetReady()
    {
        Console.WriteLine("Get ready to start the activity!");
    }
    public void ShowAnimation(int)
    {

    }

    public string ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        return "Go!";
    }
}