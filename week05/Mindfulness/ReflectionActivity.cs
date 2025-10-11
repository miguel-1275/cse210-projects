using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Think of a moment when you felt proud of yourself.",
        "Recall a time when you helped someone else.",
        "Reflect on an experience that taught you an important lesson.",
        "Think about a moment when you overcame a challenge."
    };

    private string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "How did it impact the way you see yourself?",
        "What did you learn from this moment?",
        "How can you apply this insight in the future?"
    };

    public ReflectionActivity(int duration) : base("Reflection Activity", "This activity will guide you through prompts and questions to help you think deeply about meaningful experiences in your life.", duration)
    {
    }

    public void StartReflection()
    {
        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string prompt = _prompts[rand.Next(_prompts.Length)];
            Console.WriteLine($"\nPrompt: {prompt}\n");
            ShowSpinner(10000);

            for (int i = 0; i < 3; i++)
            {
                string question = _questions[rand.Next(_questions.Length)];
                Console.WriteLine($"  - {question}");
                ShowSpinner(6000);
            }
        }
    }

    private void ShowSpinner(int durationMs)
    {
        string[] frames = { "/", "-", "\\", "|" };
        int frameTime = 200;

        DateTime endTime = DateTime.Now.AddSeconds(durationMs / 1000);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{frames[i]}");
            Thread.Sleep(frameTime);
            i = (i + 1) % frames.Length;
        }

        Console.Write("\r \r");
    }
}
