using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> group = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number:  ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                group.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in group)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / group.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = group[0];
        foreach (int number in group)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}