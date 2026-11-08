public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string prompt, string entryTxt)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entryTxt;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }
}