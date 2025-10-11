using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathing = CreateBreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.DisplayGetReady();
                    breathing.StartBreathing();
                    breathing.DisplayEndingMessage();
                    break;

                case "2":
                    Console.Clear();
                    ReflectionActivity reflection = CreateReflectionActivity();
                    reflection.DisplayStartingMessage();
                    reflection.DisplayGetReady();
                    reflection.StartReflection();
                    reflection.DisplayEndingMessage();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listing = CreateListingActivity();
                    listing.DisplayStartingMessage();
                    listing.DisplayGetReady();
                    listing.StartListing();
                    listing.DisplayEndingMessage();
                    break;

                case "4":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }

    static BreathingActivity CreateBreathingActivity()
    {
        Console.Write("Enter duration of the breathing activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        return new BreathingActivity(duration);
    }

    static ReflectionActivity CreateReflectionActivity()
    {
        Console.Write("Enter duration of the reflection activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        return new ReflectionActivity(duration);
    }

    static ListingActivity CreateListingActivity()
    {
        Console.Write("Enter duration of the listing activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        return new ListingActivity(duration);
    }
}
