// After the user types the option to quit the program, a confirmation message is displayed allowing for the user to type either
// Y or N (non-case sensitive answer); the program runs again if the user types N and finishes if the user types Y (asks again if
// another letter is entered)

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        string option = "0";
        string confirmation = "";

        Console.WriteLine("Welcome to your personal journal program ;)");

        while (option != "5" && option.ToLower() != "quit")
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Please, select one option (enter the number or the uppercase word): ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("1. WRITE a new entry");
            Console.WriteLine("2. DISPLAY recent entries");
            Console.WriteLine("3. LOAD entries from a file");
            Console.WriteLine("4. SAVE entries to a file");
            Console.WriteLine("5. QUIT (delete non-saved entries)");
            Console.WriteLine();
            Console.Write("Type your choice here: ");
            option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1" || option.ToLower() == "write")
            {
                PromptGenerator prompts = new PromptGenerator();
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM-dd-yyyy");
                newEntry._entryText = Console.ReadLine();
                newEntry._prompt = prompt;

                currentJournal.AddEntry(newEntry);

                Console.WriteLine();
                Console.WriteLine("Entry saved to the journal");
            }

            else if (option == "2" || option.ToLower() == "display")
            {
                currentJournal.DisplayAll();
            }

            else if (option == "3" || option.ToLower() == "load")
            {
                Console.Write("Enter the file's name: ");
                string filename = Console.ReadLine();

                currentJournal.LoadFromFile(filename);
            }

            else if (option == "4" || option.ToLower() == "save")
            {
                Console.Write("Enter the file's name: ");
                string filename = Console.ReadLine();

                currentJournal.SaveToFile(filename);
            }

            else if (option == "5" || option.ToLower() == "quit")
            {
                do
                {
                    Console.Write("Are you sure you want to quit? Unsaved entries will be deleted (Y/N): ");
                    confirmation = Console.ReadLine();

                    if (confirmation.ToLower() == "y")
                    {
                        break;
                    }

                    else if (confirmation.ToLower() == "n")
                    {
                        option = "";
                    }

                    else
                    {
                        Console.WriteLine("You have not entered a valid option, try again.");
                    }

                } while (confirmation.ToLower() != "y" && confirmation.ToLower() != "n");
            }
            else
            {
                Console.WriteLine("Sorry, you have not entered a valid option. Try again");
            }
        }
    }
}