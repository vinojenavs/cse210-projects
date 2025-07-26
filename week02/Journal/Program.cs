using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;

        do
        {
            Console.WriteLine("Daily Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("👋 Goodbye!");
                    break;
                default:
                    Console.WriteLine("⚠️ Invalid option. Please try again.\n");
                    break;
            }

        } while (choice != "5");
    }
}