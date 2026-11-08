public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // This "mood" is part of Creativity and Exceeding Requirements
    public string _mood;

    public Entry(string date, string prompt, string mood, string entryTxt)
    {
        _date = date;
        _promptText = prompt;
        _mood = mood;
        _entryText = entryTxt;
    }

    public void Display()
    {
        Console.WriteLine($"DATE: {_date}");
        Console.WriteLine($"PROMPT: {_promptText}");
        Console.WriteLine($"MOOD: {_promptText}");
        Console.WriteLine($"THOUGHTS: {_entryText}");
    }
}