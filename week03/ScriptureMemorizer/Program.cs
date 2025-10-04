// Added the function to keep tracks of the words that have been already hidden and choose different words to hide every time
// the user presses enter (Some AI was used to fix errors and complete the enhancement)

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 43, 45);

        string verseText = "Nevertheless, the Nephites were inspired by a better cause, for they were not fighting for monarchy nor power but they were fighting for their homes and their liberties, their wives and their children, and their all, yea, for their rites of worship and their church.";

        Scripture scripture = new Scripture(reference, verseText);

        int wordsToHideEachStep = 3;

        while (true)
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Program finished.");
                break;
            }

            Console.Write("Press Enter to hide more words (or type \"quit\" to exit): ");
            string input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHideEachStep);
        }
    }
}
