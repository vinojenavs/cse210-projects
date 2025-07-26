using System;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}