using System;
using System.Diagnostics;
class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Perform()
    {
        Start();
        End();
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}");

        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _duration) && _duration > 0)
            {
                break;
            }
            Console.WriteLine("Invalid input.");
        }

        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("Well done!!");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds. of {_name} Activity");
        PauseWithSpinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

}