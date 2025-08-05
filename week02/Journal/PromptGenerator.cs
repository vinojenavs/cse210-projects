using System;
class PromptGenerator
{
    public List<string> _prompts = new List<string>
    
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?"
    };
    public static Random random = new Random();
    public string GetRandomPrompt()
    {
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
}