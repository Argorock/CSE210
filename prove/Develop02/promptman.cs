using System;
using Microsoft.VisualBasic;

class PromptMan
{
    public  List<string> prompts = new List<string>
{
    "Who was the most interesting person I interacted with today?", 
    "Who was the most supportive person I interacted with today?", 
    "Who challenged me or pushed me out of my comfort zone today?", 
    "What was the best part of my day?", 
    "What was the most enjoyable part of my day?", 
    "What was the best surprise of my day?", 
    "What was a moment of peace or calm in my day?", 
    "What was the most meaningful conversation I had today?", 
    "Who did I help or make a positive impact on today?", 
    "What was the most interesting thing someone said to me today?", 
    "What am I grateful for today?", 
    "What accomplishment am I proud of today?", 
    "What made me smile today?", 
    "How did I see God's love and care in my life today?", 
    "How did I experience God's presence today?", 
    "What lesson or truth did I learn about God today?", 
    "How did God provide for me or meet my needs today?", 
    "What was the strongest emotion I felt today?", 
    "What triggered a strong emotional response in me today?", 
    "How did I manage my emotions today?", 
    "What did I learn about myself and my emotions today?", 
    "How can I better manage my emotions in the future?", 
    "If I had one thing I could do over today, what would it be?", 
    "What would I do differently if I had the chance?", 
    "What did I learn from my mistakes today?", 
    "What would I do to improve my situation or circumstances?", 
    "What am I proud of accomplishing today?", 
    "What's been on my mind lately?", 
    "What's been weighing heavily on my heart?", 
    "What am I thinking about right now?", 
    "What's my heart's desire?", 
    "What's the first thing that comes to mind when I think about my day?"
};

    public static string GetRandomPrompt(List<string> prompts)
    {
        var random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}