using System;
class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.") { }

    public override void Perform()
    {
        base.Start();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(6);
        }

        End();
    }
}