using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing Activity", "Controlling your breath consciously helps clear your mind and improve focus.", duration)
    {
    }

    public void StartBreathing()
    {
        int inhaleTime = 4;
        int holdTime = 2;
        int exhaleTime = 4;

        int totalTime = GetDuration();
        int elapsed = 0;

        while (elapsed < totalTime)
        {
            int remaining = totalTime - elapsed;

            int currentInhale = Math.Min(inhaleTime, remaining);
            elapsed += currentInhale;
            ShowPhase("Breathe in", currentInhale, new string[] { " . ", " o ", " O ", "( )" }, 1000);

            if (elapsed >= totalTime) break;

            int currentHold = Math.Min(holdTime, totalTime - elapsed);
            elapsed += currentHold;
            ShowPhase("Hold your breath", currentHold, new string[] { "/", "-", "\\", "|" }, 500);

            if (elapsed >= totalTime) break;

            int currentExhale = Math.Min(exhaleTime, totalTime - elapsed);
            elapsed += currentExhale;
            ShowPhase("Breathe out", currentExhale, new string[] { "( )", " O ", " o ", " . " }, 1000);
        }
    }

    private void ShowPhase(string phaseName, int seconds, string[] frames, int frameDurationMs)
    {
        int frameIndex = 0;
        int iterations = (seconds * 1000) / frameDurationMs;

        for (int i = 0; i < iterations; i++)
        {
            Console.Clear();
            Console.WriteLine(phaseName);
            int remainingSeconds = seconds - (i * frameDurationMs) / 1000;
            if (remainingSeconds < 0) remainingSeconds = 0;
            Console.WriteLine($"Time remaining: {remainingSeconds} sec");
            Console.WriteLine(frames[frameIndex]);
            frameIndex = (frameIndex + 1) % frames.Length;
            Thread.Sleep(frameDurationMs);
        }

        Console.Clear();
    }
}
