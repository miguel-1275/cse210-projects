public class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "List as many things as you can that make you happy.",
        "List people who have positively influenced your life.",
        "List achievements you are proud of.",
        "List activities that help you feel calm and relaxed."
    };

    public ListingActivity(int duration) : base("Listing Activity", "This activity challenges you to list as many items as you can in response to a prompt.", duration)
    {
    }

    public void StartListing()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine($"\nPrompt: {prompt}");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> userResponses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userResponses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items. Great job!");
    }
}
