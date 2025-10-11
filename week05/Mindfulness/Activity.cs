public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void AskDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great! You spent {_duration} seconds on the {_name}");
    }
    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        ShowBouncingOrb(5);
    }

    public void ShowBouncingOrb(int seconds)
    {
        string[] frames = new string[]
        {
            ".....",
            "o....",
            "Oo...",
            "oOo..",
            ".oOo.",
            "..oOo",
            "...oO",
            "....o",
            ".....",
            "....o",
            "...oO",
            "..oOo",
            ".oOo.",
            "oOo..",
            "Oo...",
            "o....",
            "....."
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{frames[i]}");
            Thread.Sleep(150);
            i = (i + 1) % frames.Length;
        }

        Console.Write("\r     \r");
    }
}
