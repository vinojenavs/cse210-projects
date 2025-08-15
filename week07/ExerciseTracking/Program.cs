using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 8, 10), 30, 3.0),
            new Cycling(new DateTime(2025, 8, 12), 45, 15.0),
            new Swimming(new DateTime(2025, 8, 14), 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
