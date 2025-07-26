using System;

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private static Random random = new Random();

    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "What am I grateful for today?"
    };

    public void WriteNewEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine("New Journal Entry");
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        entries.Add(entry);
        Console.WriteLine("✅ Entry added!\n");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries");
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
                Console.WriteLine("-------------------------");
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine("===ENTRY_END===");
            }
        }

        Console.WriteLine($"✅ Journal saved to '{filename}'.\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("⚠️ File not found.\n");
            return;
        }

        entries.Clear();  // Clear current entries

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string dateLine = reader.ReadLine();
                string promptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();
                string separator = reader.ReadLine();  // ===ENTRY_END===

                if (dateLine != null && promptLine != null && responseLine != null)
                {
                    entries.Add(new JournalEntry
                    {
                        Date = DateTime.Parse(dateLine),
                        Prompt = promptLine,
                        Response = responseLine
                    });
                }
            }
        }

        Console.WriteLine($"✅ Journal loaded from '{filename}'.\n");
    }
}
