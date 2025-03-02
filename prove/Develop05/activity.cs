using System.Security.Cryptography.X509Certificates;

class Activity
{
    protected int _duration;
    private string _name;
    private string _description;

    public Activity()
    {
        _name = "Unknown";
        _description = "Unknown";
        _duration = 0;
    }


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayIntro()
    {
        Console.WriteLine("Welcome to the activity: " + _name);
        Console.WriteLine("Description: " + _description);
    }


    public void PromptDuration()
    {
        System.Console.WriteLine("");
        Console.Write("Please enter the duration of the activity in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        
    }


    public void ShowGetReady()
    {
        Console.WriteLine("Get ready to start the activity!");
        ShowCountDown(5);
    }

    public string ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r The Activity will start in {i} seconds ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("");
        return "Go!";
    }





    public void ShowAnimation()
    {
   
        for (int i = 5; i > 0; i--)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(i);

            if (i == 5)
            {
                Console.WriteLine("                                   /\\");
                Console.WriteLine("                              /\\  //\\\\");
                Console.WriteLine("                       /\\    //\\\\///\\\\\\        /\\");
                Thread.Sleep(1000);
            // Console.Clear();
            }
            if (i == 4)
            {
                Console.WriteLine("                                   /\\");
                Console.WriteLine("                              /\\  //\\\\");
                Console.WriteLine("                       /\\    //\\\\///\\\\\\        /\\");
                Console.WriteLine("                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\");
                Console.WriteLine("         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\");
                Console.WriteLine("        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\");
                Thread.Sleep(1000);
            // Console.Clear();
            }
            if (i == 3)
            {
                Console.WriteLine("                                   /\\");
                Console.WriteLine("                              /\\  //\\\\");
                Console.WriteLine("                       /\\    //\\\\///\\\\\\        /\\");
                Console.WriteLine("                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\");
                Console.WriteLine("         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\");
                Console.WriteLine("        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\");
                Console.WriteLine("       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *");
                Console.WriteLine("      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\");
                Console.WriteLine("     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\");
                Thread.Sleep(1000);
            // Console.Clear();
            }
            if (i == 2)
            {
                Console.WriteLine("                                   /\\");
                Console.WriteLine("                              /\\  //\\\\");
                Console.WriteLine("                       /\\    //\\\\///\\\\\\        /\\");
                Console.WriteLine("                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\");
                Console.WriteLine("         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\");
                Console.WriteLine("        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\");
                Console.WriteLine("       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *");
                Console.WriteLine("      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\");
                Console.WriteLine("     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\");
                Console.WriteLine("    / ^^  ^ ^ ^\\  /______________________________\\ ^ ^ \\ /|o|||\\");
                Console.WriteLine("   /  ^  ^^ ^ ^  /________________________________\\  ^  /|||||o|\\");
                Console.WriteLine("  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\\       ");
                Thread.Sleep(1000);
            // Console.Clear();
            }
            if (i == 1)
            {   
                Console.WriteLine("                                   /\\");
                Console.WriteLine("                              /\\  //\\\\");
                Console.WriteLine("                       /\\    //\\\\///\\\\\\        /\\");
                Console.WriteLine("                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\");
                Console.WriteLine("         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\");
                Console.WriteLine("        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\");
                Console.WriteLine("       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *");
                Console.WriteLine("      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\");
                Console.WriteLine("     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\");
                Console.WriteLine("    / ^^  ^ ^ ^\\  /______________________________\\ ^ ^ \\ /|o|||\\");
                Console.WriteLine("   /  ^  ^^ ^ ^  /________________________________\\  ^  /|||||o|\\");
                Console.WriteLine("  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\\       ");
                Console.WriteLine(" / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |           ");
                Console.WriteLine("/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo  ");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Thread.Sleep(1000);
            }
        }
            Console.Clear();

        
        

    }


}