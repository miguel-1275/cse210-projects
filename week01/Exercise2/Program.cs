using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percentage (0-100): ");
        string input = Console.ReadLine();
        float score = int.Parse(input);

        string letter = "";
        string symbol = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "F")
        {
            symbol = "";
        }
        else if ((score % 10) >= 7 && letter != "A")
        {
            symbol = "+";
        }
        else if ((score % 10) < 3)
        {
            symbol = "-";
        }

        Console.WriteLine($"Your grade is {letter}{symbol}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the course. Better luck next time.");
        }
    }
}