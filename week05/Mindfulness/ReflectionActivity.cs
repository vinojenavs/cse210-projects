using System;
using System.Diagnostics.CodeAnalysis;
class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Perform()
    {
        Start();
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind press enter to continue");

        
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                string question = GetUniqueQuestion();
                Console.WriteLine($"> {question} ");
            }
        }

        End();
    }

    public string GetUniqueQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        string question;
        do
        {
            question = _questions[new Random().Next(_questions.Count)];
        } while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }
}