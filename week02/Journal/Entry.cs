public class Entry
{
    public string _entryText;
    public string _date;
    // DateTime.Now.ToString("MM-dd-yyyy")
    public string _prompt;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}