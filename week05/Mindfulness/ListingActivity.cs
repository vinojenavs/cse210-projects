using System;
class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.") { }

    public override void Perform()
    {
        Start();
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Start listing items (press Enter after each one):");
        Countdown(5);
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
}