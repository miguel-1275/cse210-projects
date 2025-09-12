using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int totalSum = 0;
        int greatest = 0;

        do
        {
            Console.Write("Enter a new number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            totalSum += numbers[i];

            if (numbers[i] > greatest)
            {
                greatest = numbers[i];
            }
        }

        Console.WriteLine($"The greatest number was {greatest}");
        Console.WriteLine($"The total sum of the numbers is {totalSum}");
    }
}