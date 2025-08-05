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

/**
class JournalEntry
{
    public DateTime _date;
    public string _prompt;
    public string _response;
    public string EntryText()
    {
        return $"Date: {_date.ToShortDateString} Prompt: {_prompt} Response: {_response}";
    }
}
**/