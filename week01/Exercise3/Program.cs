using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess;
        int times = 0;

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            times++;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        }   while (guess != number);

        Console.WriteLine($"You guessed it! It took you {times} attempts");
    }
}