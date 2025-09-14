public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What made you laugh the most today?",
        "Who did you make something good for today? What was it?",
        "What whas something you learned about your family today?",
        "Which one of your today's achievements would you like to remember?",
        "What would you do different if you could go back in time this day?",
        "From the places you visited today, which one was your favorite?",
    };

    public string GetRandomPrompt()
    {
        Random rng = new Random();

        int index = rng.Next(0, _prompts.Count());

        return _prompts[index];
    }
}